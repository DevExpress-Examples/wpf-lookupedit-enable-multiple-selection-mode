using System.Collections.Generic;
using System.Windows;

namespace WpfApplication68 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }

    public static class Helper {
        public static List<Employee> Data {
            get {
                List<Employee> staff = new List<Employee> {
                    new Employee() { Name = "Gregory S. Price", Department = "", Position = "President" },
                    new Employee() { Name = "Irma R. Marshall", Department = "Marketing", Position = "Vice President" },
                    new Employee() { Name = "John C. Powell", Department = "Operations", Position = "Vice President" },
                    new Employee() { Name = "Christian P. Laclair", Department = "Production", Position = "Vice President" },
                    new Employee() { Name = "Karen J. Kelly", Department = "Finance", Position = "Vice President" },

                    new Employee() { Name = "Brian C. Cowling", Department = "Marketing", Position = "Manager" },
                    new Employee() { Name = "Thomas C. Dawson", Department = "Marketing", Position = "Manager" },
                    new Employee() { Name = "Angel M. Wilson", Department = "Marketing", Position = "Manager" },
                    new Employee() { Name = "Bryan R. Henderson", Department = "Marketing", Position = "Manager" },

                    new Employee() { Name = "Harold S. Brandes", Department = "Operations", Position = "Manager" },
                    new Employee() { Name = "Michael S. Blevins", Department = "Operations", Position = "Manager" },
                    new Employee() { Name = "Jan K. Sisk", Department = "Operations", Position = "Manager" },
                    new Employee() { Name = "Sidney L. Holder", Department = "Operations", Position = "Manager" },

                    new Employee() { Name = "James L. Kelsey", Department = "Production", Position = "Manager" },
                    new Employee() { Name = "Howard M. Carpenter", Department = "Production", Position = "Manager" },
                    new Employee() { Name = "Jennifer T. Tapia", Department = "Production", Position = "Manager" },

                    new Employee() { Name = "Judith P. Underhill", Department = "Finance", Position = "Manager" },
                    new Employee() { Name = "Russell E. Belton", Department = "Finance", Position = "Manager" }
                };
                return staff;
            }
        }
    }

    public class Employee {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
    }
}