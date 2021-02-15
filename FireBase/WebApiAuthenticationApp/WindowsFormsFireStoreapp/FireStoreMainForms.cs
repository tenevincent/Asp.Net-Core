using Google.Cloud.Firestore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsFireStoreapp
{
    public partial class FireStoreMainForms : Form
    {

        // see the documentation here:
        // https://github.com/GoogleCloudPlatform/dotnet-docs-samples/blob/c7e7fcce0bc537509fd0456aa7676592aff694ef/firestore/api/Quickstart/Program.cs#L37-L38


        private FirestoreDb _firebaseApp;
        private DocumentReference docRef;

        public FireStoreMainForms()
        {
            InitializeComponent();
        }


 
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // C:\\Development\\developertools\\googlecloud\\service-account-file.json
                this._firebaseApp = FirestoreDb.Create("fir-cookbook-a1787");
                // _firebaseClient = new FireSharp.FirebaseClient(fcon);
            }
            catch (Exception ex)
            {
                MessageBox.Show("there was problem in the internet.");
            }
        }

        async private void InsertBtn_Click(object sender, EventArgs e)
        {
            Student std = new Student()
            {
                FullName = nameTbox.Text,
                RollNo = rollTbox.Text,
                Grade = gradeTobx.Text,
                Section = secTbox.Text
            };
            //var setter = _firebaseClient.Set("StudentList/"+rollTbox.Text,std);

            var notificationId = Guid.NewGuid().ToString();
            textBoxNotification.Text = notificationId;


            this.docRef = _firebaseApp.Collection("studentsList")
                .Document(rollTbox.Text).Collection("Notifications")
                .Document(textBoxNotification.Text);


            Dictionary<string, object> student = GetGetStudent();
            Dictionary<string, object> user = student;

            await docRef.SetAsync(user);
            MessageBox.Show("data inserted successfully");
        }

        private Dictionary<string, object> GetGetStudent()
        {
            return new Dictionary<string, object>
            {
                { "FullName",  nameTbox.Text },
                { "RollNo",textBoxNotification.Text},
                { "Grade", gradeTobx.Text },
                { "Section", secTbox.Text }
            };
        }

        async private void SelectBtn_Click(object sender, EventArgs e)
        {

            var result = _firebaseApp.Collection("studentsList")
                .Document(rollTbox.Text).Collection("Notifications")
                .Document(textBoxNotification.Text); 

            var document = await result.GetSnapshotAsync();


            Console.WriteLine("User: {0}", document.Id);

            Dictionary<string, object> documentDictionary = document.ToDictionary();
            var jsonDoc = JsonConvert.SerializeObject(documentDictionary);

            var student = JsonConvert.DeserializeObject<Student>(jsonDoc);
 
            nameTbox.Text = student.FullName;
            gradeTobx.Text = student.Grade;
            secTbox.Text = student.Section;
            MessageBox.Show("data retrieved successfully");
        }

       async private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Student std = new Student()
            {
                FullName = nameTbox.Text,
                RollNo = rollTbox.Text,
                Grade = gradeTobx.Text,
                Section = secTbox.Text
            };

            var document = _firebaseApp.Collection("studentsList")
              .Document(rollTbox.Text).Collection("Notifications")
              .Document(textBoxNotification.Text);
            Dictionary<string, object> student = GetGetStudent();
          await  document.UpdateAsync(student);
            //var setter = _firebaseApp.Update("StudentList/" + rollTbox.Text, std);
            MessageBox.Show("data inserted successfully");
        }

        async private void DeleteBtn_Click(object sender, EventArgs e)
        {

            var document = _firebaseApp.Collection("studentsList")
                .Document(rollTbox.Text).Collection("Notifications")
                .Document(textBoxNotification.Text); 

            //  var result = _firebaseApp.Collection("studentsList").Document(rollTbox.Text);
            await document.DeleteAsync();


            // var result = _firebaseApp.Delete("StudentList/" + rollTbox.Text);
            MessageBox.Show("data deleted successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            nameTbox.Text = "";
            rollTbox.Text = "";
            gradeTobx.Text = "";
            secTbox.Text = "";

        }
    }
}
