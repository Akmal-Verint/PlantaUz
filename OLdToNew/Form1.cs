using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.CacheProviders;
using GMap.NET.Internals;
using GMap.NET.MapProviders;
using GMap.NET.ObjectModel;
using GMap.NET.Projections;
using GMap.NET.WindowsForms;


namespace OLdToNew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plantasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.plantasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.plantauzDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            // TODO: данная строка кода позволяет загрузить данные в таблицу "plantauzDataSet.Areas". При необходимости она может быть перемещена или удалена.
            this.areasTableAdapter.Fill(this.plantauzDataSet.Areas);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "plantauzDataSet.images". При необходимости она может быть перемещена или удалена.
            this.imagesTableAdapter.Fill(this.plantauzDataSet.images);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "plantauzDataSet.plantas". При необходимости она может быть перемещена или удалена.
            this.plantasTableAdapter1.Fill(this.plantauzDataSet.plantas);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "plantauzoldDataSet.plantas". При необходимости она может быть перемещена или удалена.
            this.plantasTableAdapter.Fill(this.plantauzoldDataSet.plantas);

            int plantasoldCount = this.plantasBindingSource.Count;
            for (int i = 0; i < plantasoldCount; i++)
            {
                this.plantasBindingSource.Position = i;
                this.plantasBindingSource.RemoveCurrent();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < length; i++)
            {

            }

            this.plantasBindingSource.AddNew();
            ((DataRowView)this.plantasBindingSource.Current).Row[0] = ((DataRowView)this.plantasoldBindingSource.Current).Row[0];
            ((DataRowView)this.plantasBindingSource.Current).Row[1] = ((DataRowView)this.plantasoldBindingSource.Current).Row[1];
            ((DataRowView)this.plantasBindingSource.Current).Row[2] = ((DataRowView)this.plantasoldBindingSource.Current).Row[2];
            ((DataRowView)this.plantasBindingSource.Current).Row[3] = ((DataRowView)this.plantasoldBindingSource.Current).Row[3];
            ((DataRowView)this.plantasBindingSource.Current).Row[4] = ((DataRowView)this.plantasoldBindingSource.Current).Row[4];
            ((DataRowView)this.plantasBindingSource.Current).Row[5] = ((DataRowView)this.plantasoldBindingSource.Current).Row[5];
            ((DataRowView)this.plantasBindingSource.Current).Row[6] = ((DataRowView)this.plantasoldBindingSource.Current).Row[13];
            ((DataRowView)this.plantasBindingSource.Current).Row[7] = ((DataRowView)this.plantasoldBindingSource.Current).Row[6];
            ((DataRowView)this.plantasBindingSource.Current).Row[8] = ((DataRowView)this.plantasoldBindingSource.Current).Row[7];
            ((DataRowView)this.plantasBindingSource.Current).Row[9] = ((DataRowView)this.plantasoldBindingSource.Current).Row[8];
            ((DataRowView)this.plantasBindingSource.Current).Row[10] = ((DataRowView)this.plantasoldBindingSource.Current).Row[9];
            ((DataRowView)this.plantasBindingSource.Current).Row[11] = ((DataRowView)this.plantasoldBindingSource.Current).Row[10];

            List<Image> images = new List<Image>();
            images = ObjectToListImages(((DataRowView)this.plantasoldBindingSource.Current).Row[14]);

            int imagesCount = this.imagesBindingSource.Count;

            for (int i = 0; i < imagesCount; i++)
            {
                this.imagesBindingSource.Position = i;
                this.imagesBindingSource.RemoveCurrent();
            }

            for (int i = 0; i < images.Count; i++)
            {
                this.imagesBindingSource.AddNew();
                ((DataRowView)this.imagesBindingSource.Current).Row[1] = ((DataRowView)this.plantasBindingSource.Current).Row[0];
                ((DataRowView)this.imagesBindingSource.Current).Row[2] = ImageToObject(images[i]);
            }

            int areasCount = this.areasBindingSource.Count;

            for (int i = 0; i < areasCount; i++)
            {
                this.areasBindingSource.Position = i;
                this.areasBindingSource.RemoveCurrent();
            }


            if (!DBNull.Value.Equals(((DataRowView)this.plantasoldBindingSource.Current).Row[11]))
            {
                GMapOverlay overlay = new GMapOverlay();

                object obj = ((DataRowView)this.plantasoldBindingSource.Current).Row[11];

                obj = ObjectToGMapOverlay(obj);

                overlay = (GMapOverlay)obj;

                for (int i = 0; i < overlay.Polygons.Count; i++)
                {
                    this.areasBindingSource.AddNew();
                    ((DataRowView)this.areasBindingSource.Current).Row[1] = ((DataRowView)this.plantasBindingSource.Current).Row[0];
                    ((DataRowView)this.areasBindingSource.Current).Row[2] = ListPointLatLngToObject(overlay.Polygons[0].Points);
                }
            }
        }

        private object ListPointLatLngToObject(List<PointLatLng> source)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream();
            bf.Serialize(memoryStream, source);
            return (object)memoryStream.ToArray();
        }

        private object ObjectToGMapOverlay(object source)
        {
            byte[] byteArray = (byte[])source;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream(byteArray);
            object result = bf.Deserialize(memoryStream);
            return result;
        }

        private object ImageToObject(Image source)
        {
            MemoryStream memoryStream = new MemoryStream();
            source.Save(memoryStream, source.RawFormat);
            return (object)memoryStream.ToArray();
        }

        private List<Image> ObjectToListImages(object source)
        {
            byte[] byteArray = (byte[])source;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(byteArray);
            object result = bf.Deserialize(ms);
            return (List<Image>)result;
        }
    }
}
