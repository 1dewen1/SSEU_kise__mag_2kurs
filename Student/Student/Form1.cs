using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace student
{
    public partial class FormStudent : Form
    {
        student student1 = new student(); //объект класса студент

        public FormStudent()
        {
            InitializeComponent();
        }

        private void textBoxFIO_TextChanged(object sender, EventArgs e)
        {
            student1.FIO = textBoxFIO.Text; //сохранить ФИО
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void textBoxNstud_TextChanged(object sender, EventArgs e)
        {
            student1.Nstud = textBoxNstud.Text; //сохранить № студбилета
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void numericUpDownKurs_ValueChanged(object sender, EventArgs e)
        {
            student1.kurs = (int)numericUpDownKurs.Value; //сохранить курс
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void texGruppa_TextChanged(object sender, EventArgs e)
        {
            student1.gruppa = texGruppa.Text; //сохранить группу
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void radioButtonBudget_CheckedChanged(object sender, EventArgs e)
        {
            student1.budget = radioButtonBudget.Checked; //сохрнить бюджет/коммерческое
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }


    }
}