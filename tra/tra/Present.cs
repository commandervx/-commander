
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace tra
{
    [Serializable]
    class Present
    {
        private string name;
        private string sex;
        private string  id;
        private string city;
        private string type;
        private string address;

        public void setType(string type)
        {
            this.type = type;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public void setId(string id)
        {
            this.id = id;
        }
        public string getId()
        {
            return id;
        }
        public void setCity(string city)
        {
            this.city = city;
        }
        public string getCity()
        {
            return city;
        }

        public Present(string id,string name, string sex, string city,string type, string address)
        {
            setId(id);
            setName(name);
            setSex(sex);
            setCity(city);
            setType(type);
            setAddress(address);

        }
        public Present(string[] info)
       {//构造函数
           this.id = info[0];
           this.name = info[1];
           this.sex= info[2];
           this.city = info[3];
           this.type= info[4];
           this.address= info[5];

       }

        public string getType()
        {
            return type;
        }
        public string getAddress()
        {
            return address;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setSex(string sex)
        {
            this.sex = sex;
        }
        public string getSex()
        {
            return sex;
        }
     


    }
}