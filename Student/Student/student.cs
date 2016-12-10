using System;
using System.Collections.Generic;
using System.Text;

namespace student
{
    class student
    {
        public string FIO = "";                   //���
        public string Nstud = "000000";           //� ����������
        public int kurs = 1;                      //����
        public string gruppa = "";                //������
        public bool budget = true;                //������
        public byte[,] ozenki = new byte[8, 5];   //������


        //���������� ����� � ���� ������
        public string ToString()
        {
            //������ � ��������
            string strOzenki = "";
            //������� ���������
            for (int i = 0; i < 2 * kurs; i++)
            {
                //������� ����� �������� � ������ ������
                strOzenki += (i + 1) + "�������: ";
                //������ ���������
                for (int j = 0; j < 5; j++)
                {
                    if (ozenki[i, j] == 1) //������
                        strOzenki += "������, "; //��������� ������ � ������
                    else if (ozenki[i, j] > 1) //���� ������
                        strOzenki += ozenki[i, j] + ", "; //��������� ������ � ������
                };
                //����� ������
                strOzenki += "��������� " + Stipendia(i) + "���.\r\n";
            };
            return "���: " + FIO + "\r\n" +
                   "� ����������: " + Nstud + "\r\n" +
                   "����: " + kurs + "\r\n" +
                   "������: " + gruppa + "\r\n" +
                    strOzenki + "\r\n" +
                    "������� ����: " + SredniyBall();
        }

        //��������� �������� �� ��������� ����
        public void PerevestiNaSledKurs()
        {
            //���� ���� �� ������������, �� ��������� �� 1
            if (kurs < 4)
                kurs += 1;
        }

        //��������� ������� ����
        public double SredniyBall()
        {
            double sum = 0; //����� ������
            int n = 0; //���������� ��������� � ��������
            //��������� � ������������� ������ � �����
            for (int i =0; i < 2 * kurs; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (ozenki[i, j] > 1)
                    {
                        sum += ozenki[i, j];
                        n++;
                    };
                };
            //���� ���� ��������
            if (n > 0)
                return sum/n; //������� ���� = ����� / ����������
            else
                return 0; //������� ���� = 0
        }

        //���������� ��������� �� ��������� �������
        const decimal stipSum = 1500m; //����� ������� ���������
        const decimal stipPovyshSum = 1800m; //����� ���������� ���������
        int n = 0; //���������� ���������
        public decimal Stipendia(int semestr)
        {
            //���� ������� �� ������� �� ��������� �������
            if ((semestr >= 0) && (semestr <= 2 * kurs))
            {
                if (budget) //������� ���������
                {
                    bool stip = true; //���� ���������
                    bool stipPovysh = true; //���� ���������� ���������
                    for (int i = 0; i < 5; i++)
                    {
                        if (ozenki[semestr, i] > 0)//���� ������� ���
                        {
                            n++; //��������� ���������� ���������
                            stip &= (ozenki[semestr, i] > 3); //������� ��������� - ������ ���� 3
                            stipPovysh &= (ozenki[semestr, i] == 5); // ���������� - ������ 5
                        };
                    };
                    if (n == 0) //�� ���� ���������
                        return 0; //���� ������� ���������
                    if (stipPovysh) //���� ���������� ���������
                        return stipPovyshSum;
                    else if (stip) //���� ������� ���������
                        return stipSum;
                    else 
                        return 0;
                };
                return 0; //������������ ������� - ��� ���������
            };
            return 0; //������������ ������� - ��� ���������
        }

        //��������� ������ �������� ����� ����������� ����� �� �������
        student(student copyFrom)
        {
            //�������� �������� ���� �����
            FIO = copyFrom.FIO;
            Nstud = copyFrom.Nstud;
            kurs = copyFrom.kurs;
            gruppa = copyFrom.gruppa;
            ozenki = copyFrom.ozenki;
        }

        
    }

    class StudentPlat : student
        {
            public decimal stoimostObucheniya; //��������� �������� �� �������
            public decimal oplacheno; //������� ������� ������� � �����

            //�������� ��������
            public void OplatitObuchenie(decimal sum)
            {
                //���� ��������� �� ��������� �����
                oplacheno += sum;
            }

            // ����������� �� �������� (��� ���������, ���� �������������)
            public decimal Dolg()
            {
                //���� = ��������� �������� �� ������� * ���������� ��������� - ���������� �����
                return stoimostObuchenya * kurs *2 - oplacheno;
            }

            //�����������
            public StudentPlat(student copyFrom) : base(copyFromFrom)
            {
                //���� ������� copyFrom �������� ���������
                if (copyFrom is StudentPlat)
                {
                    //�� ����������� ��������� �������� � ����� �����,
                    //������������ copyFrom ��� ��������
                    stoimostObucheniya = (copyFrom as StudentPlat).stoimostObucheniya;
                    oplacheno = (copyFrom as StudentBudgplat).oplacheno;
                };
            }
        }

    class StudentBudg : student
        {
            //���������� ��������� �� ��������� �������
            const decimal stopSum = 1500m; //����� �� ��������� ������� 
            const decimal stipPovyshSum = 1800m //����� ������� ���������
            public decimal Stipendia(int semestr)
            {
                //���� ������� �� ������� �� ���������� �������
                if ((semestr >= 0) && (semestr <= 2 * kurs))
                {
                    bool strip = true; // ���� ��������� 
                    bool stripPovysh = true; // ���� ���������� ���������
                    int n = 0 //���������� ���������
                    for (int i = 0; i < 5; i++) // ���������� ���������
                    {
                        if (ozenki[semestr, i] > 0) //���� ������� ���
                        {
                            n++;  // ��������� ���������� ���������
                            strip &= (ozenki[semestr, i] > 3); // ������� ��������� - ������ ���� 3
                            stripPovysh &= (ozenki[semestr, i] == 5); //���������� - ������ 5
                        };
                    if (n == 0) //�� ���� ���������
                        return 0; //��� ��� ���������
                    if (stipPovyshSum) //���� ���������� ���������
                        return stipSum;
                    else 
                        return 0;
                    };
                return 0; //������������ ������� - ��� ���������
                }
            }
        }
}
