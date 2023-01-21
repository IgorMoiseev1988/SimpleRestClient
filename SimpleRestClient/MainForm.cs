using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Headers;
using System.Text.Json;

namespace SimpleRestClient
{
    public partial class MainForm : Form
    {
        private readonly HttpClient client;

        public MainForm()
        {
            InitializeComponent();
            client = new HttpClient()
            {
                BaseAddress = new Uri("https://jsonplaceholder.typicode.com")
            };
            //client = new HttpClient();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new AboutForm();
            about.ShowDialog();
        }

        private async void ButtonExecute_Click(object sender, EventArgs e)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, textBoxRequest.Text);

            SetHeaders(request);

            var response = await client.SendAsync(request);

            //Ёто использу€ срань от мелком€гких
            //if (response?.IsSuccessStatusCode ?? false)
            //{
            //    var str = await response.Content.ReadAsStringAsync();
            //    var json = JsonDocument.Parse(str);

            //    using var stream = new System.IO.MemoryStream();
            //    using var writer =new Utf8JsonWriter(stream, new JsonWriterOptions() { Indented = true});
            //    json.WriteTo(writer);
            //    writer.Flush();

            //    textBoxResponse.Text = System.Text.Encoding.UTF8.GetString(stream.ToArray());
            //}

            //ј это через Newtonsoft.json.  стати в втб он юзаетс€. Ћицензи€ у него MIT
            if(JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync()) is object obj)
                textBoxResponse.Text = JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings()
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                });
        }

        private void SetHeaders(HttpRequestMessage message)
        {

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);


        }
    }
}