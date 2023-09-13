using System.CodeDom.Compiler;

namespace FirstWinFormsApp
{
    public partial class Form1 : Form
    {
        List<PersonData> people = new List<PersonData>();


        public Form1()
        {
            InitializeComponent();

        }
        private void Savebutton_Click(object sender, EventArgs e)
        {
            PersonData persons = new PersonData();
            persons.FirstName = FirstNametextBox.Text;
            persons.LastName = LastNametextBox.Text;
            persons.Cellphone = CellphonetextBox.Text;
            persons.Nationalcode = NationalcodetextBox.Text;
            people.Add(persons);


            if (string.IsNullOrEmpty(persons.FirstName) || string.IsNullOrEmpty(persons.LastName) || string.IsNullOrEmpty(persons.Cellphone) || string.IsNullOrEmpty(persons.Nationalcode))
            {

                MessageBox.Show("Please Enter your information ! ");
                return;
            }
            persons.Cellphone = persons.Cellphone.Replace('۰', '0').Replace('۱', '1').Replace('۲', '2').Replace('۳', '3').Replace('۴', '4').Replace('۵', '5')
                                .Replace('۶', '6').Replace('۷', '7').Replace('۸', '8').Replace('۹', '9');

            if (persons.Cellphone.Length < 11 || persons.Cellphone.Length > 13 || (!persons.Cellphone.StartsWith("09") && !persons.Cellphone.StartsWith("989") && !persons.Cellphone.StartsWith("+989")))
            {
                MessageBox.Show("please enter your cell number correctly ! ");
                return;
            }
            else
            {
                if (persons.Cellphone.StartsWith("989"))
                {
                    persons.Cellphone = "0" + persons.Cellphone.Substring(2, 10);
                }
                else if (persons.Cellphone.StartsWith("+989"))
                {
                    persons.Cellphone = "0" + persons.Cellphone.Substring(3, 10);
                }
            }
            persons.Nationalcode = persons.Nationalcode.Replace('۰', '0').Replace('۱', '1').Replace('۲', '2').Replace('۳', '3').Replace('۴', '4').Replace('۵', '5')
                                .Replace('۶', '6').Replace('۷', '7').Replace('۸', '8').Replace('۹', '9');
           
            long nationalCode = 0;
            if (persons.Nationalcode.Length != 10 || !long.TryParse(persons.Nationalcode, out nationalCode))
            {
                MessageBox.Show("Please Enter your NationalCode correctly ! ");
                return;
            }
            
            string gendar = GendercomboBox.SelectedItem.ToString();

            outPutTextBox.Text = $"نام: {persons.FirstName}، نام خانوادگی: {persons.LastName}، شماره تلفن همراه: {persons.Cellphone} ، کدملی: {persons.Nationalcode} ، جنسیت: {gendar}";
        }
    }
}
