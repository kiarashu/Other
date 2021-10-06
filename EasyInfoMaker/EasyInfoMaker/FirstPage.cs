using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyInfoMaker
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void about_Click(object sender, EventArgs e)
        {
            AboutPage about = new AboutPage();
            about.Show();
        }

        private void goToStepTwo_Click(object sender, EventArgs e)
        {
            if (rdbAmorousTextFour.Checked == false && rdbAmorousTextOne.Checked == false && rdbAmorousTextThree.Checked == false && rdbAmorousTextTwo.Checked == false)
            {
                MessageBox.Show("شما باید ابتدا متنی انتخاب کنید!", "خطا!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                stepTwo.Enabled = true;
                stepOne.Enabled = false;
            }
        }

        private void backToStepOne_Click(object sender, EventArgs e)
        {
            stepOne.Enabled = true;
            stepTwo.Enabled = false;
        }

        private void stepTwo_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void llAmorousTextOneShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AmorousTextOnePage amorousTextOnePage = new AmorousTextOnePage();
            amorousTextOnePage.Show();
        }

        private void llAmorousTextTwoShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AmorousTextTwoPage amorousTextTwoPage = new AmorousTextTwoPage();
            amorousTextTwoPage.Show();
        }

        private void llAmorousTextThreeShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AmorousTextThreePage amorousTextThreePage = new AmorousTextThreePage();
            amorousTextThreePage.Show();
        }

        private void llAmorousTextFourShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AmorousTextFourPage amorousTextFourPage = new AmorousTextFourPage();
            amorousTextFourPage.Show();
        }

        private void lblStepOneHelp_Click(object sender, EventArgs e)
        {
            
        }

        private void lblStepTwoHelp_Click(object sender, EventArgs e)
        {

        }

        public void goToStepThree_Click(object sender, EventArgs e)
        {
            if (txtBrideName.Text == "" || txtGroomName.Text == "" || txtDateDay.Text == "" || txtDayMonth.Text == "" || txtDateYear.Text == "" || txtAdress.Text == "" || txtTimeFromHour.Text == "" || txtTimeFromMinute.Text == "" || txtTimeToHour.Text == "" || txtTimeToMinute.Text == "" || txtGuestsName.Text == "")
            {
                MessageBox.Show("لطفا تمامی فیلد ها را پر کنید!", "خطا!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                stepThree.Enabled = true;
                stepTwo.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stepTwo.Enabled = true;
            stepThree.Enabled = false;
        }

        private void btnReStart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            printPreviewControl1.Document = printDocument1;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fontForTexts = new Font("Tahoma", 15, FontStyle.Regular);
            if (rdbAmorousTextOne.Checked == true)
            {
                Image titr = Image.FromFile("Capture.PNG");
                Point pointTitr = new Point(1, 1);
                e.Graphics.DrawImage(titr, pointTitr);

                e.Graphics.DrawString("به نام خدا", fontForTexts, Brushes.Black, 380, 100);
                e.Graphics.DrawString("عروس خانم", fontForTexts, Brushes.Black, 620, 150);
                e.Graphics.DrawString(Convert.ToString(txtBrideName.Text), fontForTexts, Brushes.Black, 150, 150);
                e.Graphics.DrawString("آقا داماد", fontForTexts, Brushes.Black, 650, 206);
                e.Graphics.DrawString(Convert.ToString(txtGroomName.Text), fontForTexts, Brushes.Black, 150, 206);

                Image imageForRDBAmorousTextOne = Image.FromFile("AmolousTextOnePicture.PNG");
                Point pointForIMG1 = new Point(175, 350);
                e.Graphics.DrawImage(imageForRDBAmorousTextOne, pointForIMG1);

                e.Graphics.DrawString("بدین وسیله از شما", fontForTexts, Brushes.Black, 580, 900);
                e.Graphics.DrawString(Convert.ToString(txtGuestsName.Text), fontForTexts,Brushes.Black, 380, 900);
                e.Graphics.DrawString("عزیز دعوت به عمل می آید", fontForTexts, Brushes.Black, 100, 900);
                e.Graphics.DrawString("تا در مجلس ما به تاریخ", fontForTexts, Brushes.Black, 550, 927);
                e.Graphics.DrawString(Convert.ToString(txtDateDay.Text), fontForTexts, Brushes.Black, 520, 927);
                e.Graphics.DrawString("/", fontForTexts, Brushes.Black, 490, 927);
                e.Graphics.DrawString(Convert.ToString(txtDayMonth.Text), fontForTexts, Brushes.Black, 460, 927);
                e.Graphics.DrawString("/", fontForTexts, Brushes.Black, 450, 927);
                e.Graphics.DrawString(Convert.ToString(txtDateYear.Text), fontForTexts, Brushes.Black, 390, 927);

                e.Graphics.DrawString("از ساعت", fontForTexts, Brushes.Black, 300, 927);
                e.Graphics.DrawString(Convert.ToString(txtTimeFromMinute.Text), fontForTexts, Brushes.Black, 260, 927);
                e.Graphics.DrawString(":", fontForTexts, Brushes.Black, 240, 927);
                e.Graphics.DrawString(Convert.ToString(txtTimeFromHour.Text), fontForTexts, Brushes.Black, 210, 927);
                e.Graphics.DrawString("تا", fontForTexts, Brushes.Black, 185, 927);
                e.Graphics.DrawString(Convert.ToString(txtTimeToMinute.Text), fontForTexts, Brushes.Black, 150, 927);
                e.Graphics.DrawString(":", fontForTexts, Brushes.Black, 135, 927);
                e.Graphics.DrawString(Convert.ToString(txtTimeToHour.Text), fontForTexts, Brushes.Black, 90, 927);

                e.Graphics.DrawString(".در جمع ما حضور داشته باشید", fontForTexts, Brushes.Black, 480, 954);

                e.Graphics.DrawString(":آدرس", fontForTexts, Brushes.Black, 690, 981);

                e.Graphics.DrawString(Convert.ToString(txtAdress.Text), fontForTexts, Brushes.Black, 100, 1008);
            }
            if (rdbAmorousTextTwo.Checked == true)
            {
                Image titr = Image.FromFile("Capture.PNG");
                Point pointTitr = new Point(1, 1);
                e.Graphics.DrawImage(titr, pointTitr);

                e.Graphics.DrawString("به نام خدا", fontForTexts, Brushes.Black, 380, 100);
                e.Graphics.DrawString("عروس خانم", fontForTexts, Brushes.Black, 620, 150);
                e.Graphics.DrawString(Convert.ToString(txtBrideName.Text), fontForTexts, Brushes.Black, 150, 150);
                e.Graphics.DrawString("آقا داماد", fontForTexts, Brushes.Black, 650, 206);
                e.Graphics.DrawString(Convert.ToString(txtGroomName.Text), fontForTexts, Brushes.Black, 150, 206);

                Image imageForRDBAmorousTextOne = Image.FromFile("AmolousTextTwoPicture.PNG");
                Point pointForIMG1 = new Point(110, 350);
                e.Graphics.DrawImage(imageForRDBAmorousTextOne, pointForIMG1);

                e.Graphics.DrawString("بدین وسیله از شما", fontForTexts, Brushes.Black, 580, 900);
                e.Graphics.DrawString(Convert.ToString(txtGuestsName.Text), fontForTexts, Brushes.Black, 380, 900);
                e.Graphics.DrawString("عزیز دعوت به عمل می آید", fontForTexts, Brushes.Black, 100, 900);
                e.Graphics.DrawString("تا در مجلس ما به تاریخ", fontForTexts, Brushes.Black, 550, 927);
                e.Graphics.DrawString(Convert.ToString(txtDateDay.Text), fontForTexts, Brushes.Black, 520, 927);
                e.Graphics.DrawString("/", fontForTexts, Brushes.Black, 490, 927);
                e.Graphics.DrawString(Convert.ToString(txtDayMonth.Text), fontForTexts, Brushes.Black, 460, 927);
                e.Graphics.DrawString("/", fontForTexts, Brushes.Black, 450, 927);
                e.Graphics.DrawString(Convert.ToString(txtDateYear.Text), fontForTexts, Brushes.Black, 390, 927);

                e.Graphics.DrawString("از ساعت", fontForTexts, Brushes.Black, 300, 927);
                e.Graphics.DrawString(Convert.ToString(txtTimeFromMinute.Text), fontForTexts, Brushes.Black, 260, 927);
                e.Graphics.DrawString(":", fontForTexts, Brushes.Black, 240, 927);
                e.Graphics.DrawString(Convert.ToString(txtTimeFromHour.Text), fontForTexts, Brushes.Black, 210, 927);
                e.Graphics.DrawString("تا", fontForTexts, Brushes.Black, 185, 927);
                e.Graphics.DrawString(Convert.ToString(txtTimeToMinute.Text), fontForTexts, Brushes.Black, 150, 927);
                e.Graphics.DrawString(":", fontForTexts, Brushes.Black, 135, 927);
                e.Graphics.DrawString(Convert.ToString(txtTimeToHour.Text), fontForTexts, Brushes.Black, 90, 927);

                e.Graphics.DrawString(".در جمع ما حضور داشته باشید", fontForTexts, Brushes.Black, 480, 954);

                e.Graphics.DrawString(":آدرس", fontForTexts, Brushes.Black, 690, 981);

                e.Graphics.DrawString(Convert.ToString(txtAdress.Text), fontForTexts, Brushes.Black, 100, 1008);
            }
            if (rdbAmorousTextThree.Checked == true)
            {
                Image titr = Image.FromFile("Capture.PNG");
                Point pointTitr = new Point(1, 1);
                e.Graphics.DrawImage(titr, pointTitr);

                e.Graphics.DrawString("به نام خدا", fontForTexts, Brushes.Black, 380, 100);
                e.Graphics.DrawString("عروس خانم", fontForTexts, Brushes.Black, 620, 150);
                e.Graphics.DrawString(Convert.ToString(txtBrideName.Text), fontForTexts, Brushes.Black, 150, 150);
                e.Graphics.DrawString("آقا داماد", fontForTexts, Brushes.Black, 650, 206);
                e.Graphics.DrawString(Convert.ToString(txtGroomName.Text), fontForTexts, Brushes.Black, 150, 206);

                Image imageForRDBAmorousTextOne = Image.FromFile("AmolousTextThreePicture.PNG");
                Point pointForIMG1 = new Point(175, 330);
                e.Graphics.DrawImage(imageForRDBAmorousTextOne, pointForIMG1);

                e.Graphics.DrawString("بدین وسیله از شما", fontForTexts, Brushes.Black, 580, 900);
                e.Graphics.DrawString(Convert.ToString(txtGuestsName.Text), fontForTexts, Brushes.Black, 380, 900);
                e.Graphics.DrawString("عزیز دعوت به عمل می آید", fontForTexts, Brushes.Black, 100, 900);
                e.Graphics.DrawString("تا در مجلس ما به تاریخ", fontForTexts, Brushes.Black, 550, 927);
                e.Graphics.DrawString(Convert.ToString(txtDateDay.Text), fontForTexts, Brushes.Black, 520, 927);
                e.Graphics.DrawString("/", fontForTexts, Brushes.Black, 490, 927);
                e.Graphics.DrawString(Convert.ToString(txtDayMonth.Text), fontForTexts, Brushes.Black, 460, 927);
                e.Graphics.DrawString("/", fontForTexts, Brushes.Black, 450, 927);
                e.Graphics.DrawString(Convert.ToString(txtDateYear.Text), fontForTexts, Brushes.Black, 390, 927);

                e.Graphics.DrawString("از ساعت", fontForTexts, Brushes.Black, 300, 927);
                e.Graphics.DrawString(Convert.ToString(txtTimeFromMinute.Text), fontForTexts, Brushes.Black, 260, 927);
                e.Graphics.DrawString(":", fontForTexts, Brushes.Black, 240, 927);
                e.Graphics.DrawString(Convert.ToString(txtTimeFromHour.Text), fontForTexts, Brushes.Black, 210, 927);
                e.Graphics.DrawString("تا", fontForTexts, Brushes.Black, 185, 927);
                e.Graphics.DrawString(Convert.ToString(txtTimeToMinute.Text), fontForTexts, Brushes.Black, 150, 927);
                e.Graphics.DrawString(":", fontForTexts, Brushes.Black, 135, 927);
                e.Graphics.DrawString(Convert.ToString(txtTimeToHour.Text), fontForTexts, Brushes.Black, 90, 927);

                e.Graphics.DrawString(".در جمع ما حضور داشته باشید", fontForTexts, Brushes.Black, 480, 954);

                e.Graphics.DrawString(":آدرس", fontForTexts, Brushes.Black, 690, 981);

                e.Graphics.DrawString(Convert.ToString(txtAdress.Text), fontForTexts, Brushes.Black, 100, 1008);
            }
            if (rdbAmorousTextFour.Checked == true)
            {
                Image titr = Image.FromFile("Capture.PNG");
                Point pointTitr = new Point(1, 1);
                e.Graphics.DrawImage(titr, pointTitr);

                e.Graphics.DrawString("به نام خدا", fontForTexts, Brushes.Black, 380, 100);
                e.Graphics.DrawString("عروس خانم", fontForTexts, Brushes.Black, 620, 150);
                e.Graphics.DrawString(Convert.ToString(txtBrideName.Text), fontForTexts, Brushes.Black, 150, 150);
                e.Graphics.DrawString("آقا داماد", fontForTexts, Brushes.Black, 650, 206);
                e.Graphics.DrawString(Convert.ToString(txtGroomName.Text), fontForTexts, Brushes.Black, 150, 206);

                Image imageForRDBAmorousTextOne = Image.FromFile("AmolousTextFourPicture.PNG");
                Point pointForIMG1 = new Point(175, 330);
                e.Graphics.DrawImage(imageForRDBAmorousTextOne, pointForIMG1);

                e.Graphics.DrawString("بدین وسیله از شما", fontForTexts, Brushes.Black, 580, 900);
                e.Graphics.DrawString(Convert.ToString(txtGuestsName.Text), fontForTexts, Brushes.Black, 380, 900);
                e.Graphics.DrawString("عزیز دعوت به عمل می آید", fontForTexts, Brushes.Black, 100, 900);
                e.Graphics.DrawString("تا در مجلس ما به تاریخ", fontForTexts, Brushes.Black, 550, 927);
                e.Graphics.DrawString(Convert.ToString(txtDateDay.Text), fontForTexts, Brushes.Black, 520, 927);
                e.Graphics.DrawString("/", fontForTexts, Brushes.Black, 490, 927);
                e.Graphics.DrawString(Convert.ToString(txtDayMonth.Text), fontForTexts, Brushes.Black, 460, 927);
                e.Graphics.DrawString("/", fontForTexts, Brushes.Black, 450, 927);
                e.Graphics.DrawString(Convert.ToString(txtDateYear.Text), fontForTexts, Brushes.Black, 390, 927);

                e.Graphics.DrawString("از ساعت", fontForTexts, Brushes.Black, 300, 927);
                e.Graphics.DrawString(Convert.ToString(txtTimeFromMinute.Text), fontForTexts, Brushes.Black, 260, 927);
                e.Graphics.DrawString(":", fontForTexts, Brushes.Black, 240, 927);
                e.Graphics.DrawString(Convert.ToString(txtTimeFromHour.Text), fontForTexts, Brushes.Black, 210, 927);
                e.Graphics.DrawString("تا", fontForTexts, Brushes.Black, 185, 927);
                e.Graphics.DrawString(Convert.ToString(txtTimeToMinute.Text), fontForTexts, Brushes.Black, 150, 927);
                e.Graphics.DrawString(":", fontForTexts, Brushes.Black, 135, 927);
                e.Graphics.DrawString(Convert.ToString(txtTimeToHour.Text), fontForTexts, Brushes.Black, 90, 927);

                e.Graphics.DrawString(".در جمع ما حضور داشته باشید", fontForTexts, Brushes.Black, 480, 954);

                e.Graphics.DrawString(":آدرس", fontForTexts, Brushes.Black, 690, 981);

                e.Graphics.DrawString(Convert.ToString(txtAdress.Text), fontForTexts, Brushes.Black, 100, 1008);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void FirstPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_3(object sender, EventArgs e)
        {

        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void txtBrideName_TextChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void stepThree_Enter(object sender, EventArgs e)
        {

        }

        private void goToStepFour_Click(object sender, EventArgs e)
        {
            stepFour.Enabled = true;
            stepThree.Enabled = false;
        }

        private void backToStepThree_Click(object sender, EventArgs e)
        {
            stepThree.Enabled = true;
            stepFour.Enabled = false;
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_4(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog1.AllowSomePages = true;
            printDialog1.ShowHelp = true;
            printDialog1.Document = printPreviewControl1.Document;
            DialogResult printResult = printDialog1.ShowDialog();
            if (printResult == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
