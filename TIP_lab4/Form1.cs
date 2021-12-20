using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TIP_lab4
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> dictionary;
        private SortedSet<string> ss;
        public Form1()
        {
            dictionary = new Dictionary<string, string>();
            ss = new SortedSet<string>();
            InitializeComponent();
            defaultMachineLoader();
        }

        private void addTranslationButton_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                try
                {                       
                    dictionary.Add(textBox3.Text + "," + textBox4.Text + "," + textBox5.Text, textBox6.Text + "," + textBox7.Text);
                    tableTranslationsListBox.Items.Add(label1.Text + textBox3.Text + "," + textBox4.Text + "," + textBox5.Text + label4.Text + textBox6.Text + "," + textBox7.Text + ")");
                }
                catch(ArgumentException){
                    return;
                }
                
            } else {
                MessageBox.Show("Одно из полей пустое. Проверьте ввод данных.");
            }
        }

        private void deleteTranslationButton_Click(object sender, EventArgs e)
        {
            if(tableTranslationsListBox.SelectedIndex != -1)
            {
                string key = tableTranslationsListBox.SelectedItems[0].ToString();
                var temp = key.Split(label4.Text);
                key = temp[0].Replace(label1.Text, string.Empty);              
                dictionary.Remove(key);              
                tableTranslationsListBox.Items.RemoveAt(tableTranslationsListBox.SelectedIndex);
            }
                
        }

        private void checkStringButton_Click(object sender, EventArgs e)
        {
            showResultTextBox.Clear();
            string chain = inputStringTextBox.Text;
            Stack<string> stack = new Stack<string>();
            stack.Push("Z");
            string currentState = "0";
            string finalState = "f";
            while (true)
            {
                string key = "";
                try
                {
                    key = currentState + "," + chain.Substring(0, 1) + "," + stack.Peek();
                } catch (ArgumentOutOfRangeException)
                {
                    key = currentState + ",*,"  + stack.Peek();
                    
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("ERROR!");
                }

                try
                {
                    chain = chain.Substring(1, chain.Length - 1);
                }
                catch (ArgumentOutOfRangeException)
                {
                    chain = "*";
                    if (stack.Count != 1)
                    {
                        MessageBox.Show("Цепочка кончилась, стек не пуст");
                        resultLabel.Text = "Цепочка не принадлежит языку";
                        return;
                    }
                }

                if (!dictionary.ContainsKey(key))
                {
                    MessageBox.Show("Неизвестный переход");
                    showResultTextBox.Text += "(q" + key + ")";
                    resultLabel.Text = "Цепочка не принадлежит языку";
                    return;
                }
                string value = dictionary[key];
                if (value.Equals("f,*"))
                {
                    resultLabel.Text = "Цепочка принадлежит языку";
                    showResultTextBox.Text += "(q" + key + ") -> (q" + value + ")";
                    return;
                }
                var temp = value.Split(",");
                currentState = temp[0];
                if(temp[1].Length == 2)
                {
                    stack.Push(temp[1].Substring(0,1));
                }
                if(temp[1].Equals("*"))
                {
                    stack.Pop();
                }
                showResultTextBox.Text += "(q" + key + ") -> (q" + value + ") |-- ";
            }

        }

        private void clearTableButton_Click(object sender, EventArgs e)
        {
            dictionary.Clear();
            tableTranslationsListBox.Items.Clear();
        }

        private void loadMachineStateButton_Click(object sender, EventArgs e)
        {
            defaultMachineLoader();
        }

        private void defaultMachineLoader()
        {
            dictionary.Clear();
            dictionary.Add("0,a,Z", "0,aZ");
            dictionary.Add("0,a,a", "0,aa");
            dictionary.Add("0,b,a", "0,a");
            dictionary.Add("0,c,a", "1,a");
            dictionary.Add("1,c,a", "2,*");
            dictionary.Add("2,c,a", "1,a");
            dictionary.Add("2,*,Z", "f,*");
            dictionary.Add("1,*,Z", "3,*");
            tableTranslationsListBox.Items.Clear();
            tableTranslationsListBox.Items.Add("(q0,a,Z)->(q0,aZ)");
            tableTranslationsListBox.Items.Add("(q0,a,a)->(q0,aa)");
            tableTranslationsListBox.Items.Add("(q0,b,a)->(q0,a)");
            tableTranslationsListBox.Items.Add("(q0,c,a)->(q1,a)");
            tableTranslationsListBox.Items.Add("(q1,c,a)->(q2,*)");
            tableTranslationsListBox.Items.Add("(q2,c,a)->(q1,a)");
            tableTranslationsListBox.Items.Add("(q2,*,Z)->(qf,*)");
            tableTranslationsListBox.Items.Add("(q1,*,Z)->(q3,*)");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void loadFromFileButton_Click(object sender, EventArgs e)
        {
            string[] textAutomat = File.ReadAllLines(@"D:\" + filePath.Text);
            dictionary.Clear();
            tableTranslationsListBox.Items.Clear();
            for (int i = 0; i < textAutomat.Length; i++)
            {
                addToDictionary(textAutomat[i]);
                tableTranslationsListBox.Items.Add(textAutomat[i]);
            }
        }

        private void addToDictionary(string text) 
        {
            string text1 = text.Substring(2, text.IndexOf(')')-2);
            string text2buf = text.Substring(text.LastIndexOf('('));
            string text2 = text2buf.Substring(2, text2buf.IndexOf(')')-2);
//            tableTranslationsListBox.Items.Add(text1);
//            tableTranslationsListBox.Items.Add(text2);
            dictionary.Add(text1, text2);
        }
    }
}