using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch01_02
{
    //INotifyPropertyChanged 원본 속성 또는 대상 속성이 변경되면 다른 항목이 자동으로 업데이트 되도록 하고 싶을 때
    public class Cust : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void Notify(string propName)
        {
            if(this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        } 



        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name == value) return;
                name = value;
                Notify("Name");
            }
        }

        private int age;

        

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (age == value) { return; }
                age = value;
                Notify("Age");
            }
        }

        public Cust() { }
        public Cust(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
