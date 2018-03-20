using System;

using AppKit;
using Foundation;

namespace TableViewApp
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            // Create the Product Table Data Source and populate it
            var DataSource = new ProductTableDataSource();
            DataSource.Products.Add(new Product("Xamarin.iOS", "Allows you to develop native iOS Applications in C#"));
            DataSource.Products.Add(new Product("Xamarin.Android", "Allows you to develop native Android Applications in C#"));
            DataSource.Products.Add(new Product("Xamarin.Mac", "Allows you to develop Mac native Applications in C#"));

            // Populate the Product Table
            TableView1.DataSource = DataSource;
            TableView1.Delegate = new ProductTableDelegate(DataSource);
        }

        partial void ClickedButton(Foundation.NSObject sender)
        {
            TableView1.BeginUpdates();

            var DataSource = new ProductTableDataSource();
            DataSource = (TableViewApp.ProductTableDataSource)TableView1.DataSource;
            DataSource.Products.Add(new Product("", ""));

            TableView1.ReloadData();

            TableView1.EndUpdates();
        }

        partial void ClickedGetButton(Foundation.NSObject sender)
        {
            var DataSource = new ProductTableDataSource();
            DataSource = (TableViewApp.ProductTableDataSource)TableView1.DataSource;

            var TitleStr = DataSource.Products[(int)TableView1.SelectedRow].Title;
            Console.WriteLine(TitleStr);

            var DescriptionStr = DataSource.Products[(int)TableView1.SelectedRow].Description;
            Console.WriteLine(DescriptionStr);
        }
    }
}
