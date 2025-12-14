using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TDashMiniStore.OldForms;

public partial class ThoiTiet : Form
{
    public ThoiTiet()
    {
        InitializeComponent();
        this.Load += Form2_Load;
        btnUpdate.Click += btnUpdate_Click;
    }


    private void Form2_Load(object sender, EventArgs e)
    {
        cbCity.Items.Add("TP.HCM");
        cbCity.Items.Add("Hà Nội");
        cbCity.Items.Add("Đà Nẵng");
        cbCity.Items.Add("Khác");
        cbCity.SelectedIndex = 1;
        cbCity.SelectedIndexChanged += cbCity_SelectedIndexChanged;
    }
    private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (cbCity.SelectedItem.ToString())
        {
            case "TP.HCM":
                txtLat.Text = "10.8231";
                txtLon.Text = "106.6297";
                break;
            case "Hà Nội":
                txtLat.Text = "21.0285";
                txtLon.Text = "105.8542";
                break;
            case "Đà Nẵng":
                txtLat.Text = "16.0544";
                txtLon.Text = "108.2022";
                break;
            case "Khác":
                txtLat.Text = "";
                txtLon.Text = "";
                break;
            default:
                break;
        }
    }
    private async Task FadeIn(PictureBox pictureBox)
    {
        if (pictureBox.Image == null) return;

        // copy ảnh gốc ra
        Image original = (Image)pictureBox.Image.Clone();
        float opacity = 0f;

        while (opacity < 1f)
        {
            Bitmap bmp = new Bitmap(original.Width, original.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity; // độ trong suốt (0 → 1)

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(original,
                            new Rectangle(0, 0, bmp.Width, bmp.Height),
                            0, 0, original.Width, original.Height,
                            GraphicsUnit.Pixel, attributes);
            }

            pictureBox.Image = bmp;
            opacity += 0.1f;        // tăng chậm → hiệu ứng mượt
            await Task.Delay(40);   // delay giữa các frame
        }

        pictureBox.Image = original; // gán lại ảnh chuẩn cuối cùng
    }


    private async Task LoadWeather()
    {
        string lat = txtLat.Text.Trim();
        string lon = txtLon.Text.Trim();

        // 🔹 Nếu chọn "Khác" mà chưa nhập vĩ độ/kinh độ → báo lỗi
        if (cbCity.SelectedItem?.ToString() == "Khác")
        {
            if (string.IsNullOrEmpty(lat) || string.IsNullOrEmpty(lon))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ kinh độ và vĩ độ  khi chọn 'Khác'.");
                return;
            }
        }
        else
        {
            // 🔹 Với các thành phố có sẵn, nếu vẫn trống → báo lỗi chung
            if (string.IsNullOrEmpty(lat) || string.IsNullOrEmpty(lon))
            {
                MessageBox.Show("Vui lòng chọn thành phố hoặc nhập tọa độ.");
                return;
            }
        }

        // 🔹 Gọi API open-meteo
        string url = $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current_weather=true&windspeed_unit=kmh";

        using var client = new HttpClient();
        var json = await client.GetStringAsync(url);

        var data = JsonDocument.Parse(json);
        var weather = data.RootElement.GetProperty("current_weather");

        double temp = weather.GetProperty("temperature").GetDouble();
        double wind = weather.GetProperty("windspeed").GetDouble();
        string time = weather.GetProperty("time").GetString();
        int code = weather.GetProperty("weathercode").GetInt32();

        txtTemp.Text = $"{temp} °C";
        txtWind.Text = $"{wind} km/h";
        txtTime.Text = $"Cập nhật lúc: {time}";

        // 🔹 Chọn icon phù hợp
        if (temp > 35)
        {
            txtTemp.ForeColor = Color.Red;
            picIcon.Image = tdash_app.Properties.Resources.sun;
        }
        else if (code >= 51 && code <= 67) // trời mưa
        {
            txtTemp.ForeColor = Color.Black;
            picIcon.Image = tdash_app.Properties.Resources.rain;
        }
        else if (wind > 30)
        {
            txtTemp.ForeColor = Color.Black;
            picIcon.Image = tdash_app.Properties.Resources.wind;
        }
        else
        {
            txtTemp.ForeColor = Color.Black;
            picIcon.Image = tdash_app.Properties.Resources.normal;
        }

        await FadeIn(picIcon);
    }

    private async void btnUpdate_Click(object sender, EventArgs e)
    {
        await LoadWeather();
    }
}
