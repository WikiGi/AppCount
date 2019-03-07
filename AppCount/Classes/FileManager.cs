using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCount.Classes
{
    class FileManager
    {
        FileStream stream;
        BinaryFormatter formatter;
        public string FilePath { get; set; }
       
        public FileManager(string FilePath)
        {
            this.FilePath = FilePath;
        }

        public object readObject() 
        {
            object answer = null;
            try
            {
                if(File.Exists(FilePath))
                {
                    stream = new FileStream(FilePath, FileMode.Open);
                    formatter = new BinaryFormatter();
                    answer = (object)(formatter.Deserialize(stream));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error al leer el archivo. Favor de reportar lo siguiente:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                answer = null;
            }
            if(stream != null) stream.Close();
            return answer;
        }

        public bool writeObject(object objeto)
        {
            bool answer = false;
            try
            {
                if(File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                }
                stream = new FileStream(FilePath, FileMode.Create);
                formatter = new BinaryFormatter();
                formatter.Serialize(stream, objeto);
                answer = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error al escribir el archivo. Favor de reportar lo siguiente:\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                answer = false;
            }
            if (stream != null) stream.Close();
            return answer;
        }
    }

}