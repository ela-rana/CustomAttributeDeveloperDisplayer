using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Conversions;
using CustomAttributeDeveloper;

namespace CustomDeveloperAttributeDisplayer
{
    public partial class Form1 : Form
    {
        List<Type> listOfClassTypes = new List<Type>(); //to save a list of all classes in the namespace
        List<string> listOfClassNames = new List<string>(); //to save a list of all class names in the 
                //namespace as a string to add to the combobox dropdown options

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();    //to get this project assembly
            Type[] types = assembly.GetTypes(); //to get a list of all types in this assembly
            foreach(Type type in types)
            {
                if (type.Namespace == "Conversions" && type.IsClass)  //if the type is in the
                    //Conversions namespace which is the one whose classes we want to check the
                    //attribute for, and the type is a class (because we only want to check classes)
                {
                    listOfClassTypes.Add(type);   //add our found classes to a Type list
                    listOfClassNames.Add(type.Name);  //also add it to a string list to feed into the dropdown 
                            //dor the combobox

                }
            }
            cmbbxSelect.DataSource = listOfClassNames; //to add the class list to our combobox drop down
            cmbbxSelect.SelectedIndex = -1; //to start off with nothing selected
            txtView.Clear();
        }

        private void cmbbxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbbxSelect.SelectedIndex != -1)
            {   
                foreach (Type t in listOfClassTypes)    //to go through our list of classes to see if it matches the
                                                        //combobox choice
                {
                    if (cmbbxSelect.SelectedItem.ToString() == t.Name)  //if it matches
                    {
                        //get the developer attribute type attribute out of that class, typecast it to a 
                        //developerattribute type then assign it to att
                        DeveloperAttribute att = 
                            (DeveloperAttribute)t.GetCustomAttribute(typeof(DeveloperAttribute));
                        if (att == null)    //there was no developer attribute to extract from this class
                        {
                            txtView.Text = "This class does not have a developer attribute"; //message
                        }
                        else //if there is a developer attribute
                        {
                            //display the developer attribute properties in our display textbox
                            txtView.Text = $"Developer Name: {att.Name}, Level: {att.Level}, Reviewed: {att.Reviewed}";
                        }
                        break;
                    }
                }
            }
        }
    }
}
