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
        student student1 = new student(); //������ ������ �������

        public FormStudent()
        {
            InitializeComponent();
        }

        private void textBoxFIO_TextChanged(object sender, EventArgs e)
        {
            student1.FIO = textBoxFIO.Text; //��������� ���
            textBoxStudentInfo.Text = student1.ToString(); //������� �� �����
        }

        private void textBoxNstud_TextChanged(object sender, EventArgs e)
        {
            student1.Nstud = textBoxNstud.Text; //��������� � ����������
            textBoxStudentInfo.Text = student1.ToString(); //������� �� �����
        }

        private void numericUpDownKurs_ValueChanged(object sender, EventArgs e)
        {
            student1.kurs = (int)numericUpDownKurs.Value; //��������� ����
            textBoxStudentInfo.Text = student1.ToString(); //������� �� �����
        }

        private void texGruppa_TextChanged(object sender, EventArgs e)
        {
            student1.gruppa = texGruppa.Text; //��������� ������
            textBoxStudentInfo.Text = student1.ToString(); //������� �� �����
        }

        private void radioButtonBudget_CheckedChanged(object sender, EventArgs e)
        {
            student1.budget = radioButtonBudget.Checked; //�������� ������/������������
            textBoxStudentInfo.Text = student1.ToString(); //������� �� �����
        }


    }
}