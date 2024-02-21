using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.EF;
using DevExpress.Persistent.BaseImpl.EF;
using SimpleProjectManager.Module.BusinessObjects;

namespace SimpleProjectManager.Module.DatabaseUpdate;

// For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
public class Updater : ModuleUpdater {
    public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
        base(objectSpace, currentDBVersion) {
    }
    public override void UpdateDatabaseAfterUpdateSchema() {
        base.UpdateDatabaseAfterUpdateSchema();

        Employee employee = ObjectSpace.FirstOrDefault<Employee>(x =>
        x.FirstName == "John" && x.LastName == "Nielsen");
        if (employee == null)
        {
            employee = ObjectSpace.CreateObject<Employee>();
            employee.FirstName = "John";
            employee.LastName = "Nielsen";
        }

        ProjectTask task = ObjectSpace.FirstOrDefault<ProjectTask>(t =>
        t.Subject == "TODO: Conditional UI Customization");
        if (task == null)
        {
            task = ObjectSpace.CreateObject<ProjectTask>();
            task.Subject = "TODO: Conditional UI Customization";
            task.Status = ProjectTaskStatus.InProgress;
            task.AssignedTo = ObjectSpace.FirstOrDefault<Employee>(p =>
            p.FirstName == "John" && p.LastName == "Nilsen");
            task.StartDate = new DateTime(2023, 1, 27);
            task.Notes = "OVERVIEW: http://www.devexpress.com/Products/NET/Application_Framework/features_appearance.xml";
        }

        Project project = ObjectSpace.FirstOrDefault<Project>(p =>
        p.Name == "DevExpress XAF Features Overview");
        if (project == null)
        {
            project = ObjectSpace.CreateObject<Project>();
            project.Name = "DevExpress XAF Features Overview";
            project.Manager = ObjectSpace.FirstOrDefault<Employee>(p =>
            p.FirstName == "John" && p.LastName == "Nilsen");
            project.ProjectTasks.Add(ObjectSpace.FirstOrDefault<ProjectTask>(t =>
            t.Subject == "TODO: Conditional UI Customization"));
        }

        Customer customer = ObjectSpace.FirstOrDefault<Customer>(c =>
        c.FirstName == "Ann" && c.LastName == "Devon");
        if (customer == null)
        {
            customer = ObjectSpace.CreateObject<Customer>();
            customer.FirstName = "Ann";
            customer.LastName = "Devon";
            customer.Company = "Eastern Connection";
        }

        User user1 = ObjectSpace.FirstOrDefault<User>(user1 =>
        user1.UserName == "Leo");
        if (user1 == null)
        {
            user1 = ObjectSpace.CreateObject<User>();
            user1.FirstName = "Leonit";
            user1.LastName = "Shabani";
            user1.Email = "leonitshabani3@gmail.com";
            user1.UserName = "Leo";
        }

        User user2 = ObjectSpace.FirstOrDefault<User>(user =>
        user.UserName == "/Bes$s1!");
        if (user2 == null)
        {
            user2 = ObjectSpace.CreateObject<User>();
            user2.FirstName = "Besian";
            user2.LastName = "Shabani";
            user2.Email = "besianshabani3@gmail.com";
            user2.UserName = "/Be$s1!";
        }

        User user3 = ObjectSpace.FirstOrDefault<User>(user =>
        user.UserName == "florianshabani");
        if (user3 == null)
        {
            user3 = ObjectSpace.CreateObject<User>();
            user3.FirstName = "Florian";
            user3.LastName = "Shabani";
            user3.Email = "florianshabani@gmail.com";
            user3.UserName = "florianshabani";
        }

        User user4 = ObjectSpace.FirstOrDefault<User>(user =>
        user.UserName == "tszdino");
        if (user4 == null)
        {
            user4 = ObjectSpace.CreateObject<User>();
            user4.FirstName = "Idris";
            user4.LastName = "Yıldırım";
            user4.Email = "idrizzz@gmail.com";
            user4.UserName = "tszdino";
        }

        User user5 = ObjectSpace.FirstOrDefault<User>(user =>
        user.UserName == "ugurxaslan");
        if (user5 == null)
        {
            user5 = ObjectSpace.CreateObject<User>();
            user5.FirstName = "Uğur";
            user5.LastName = "Aslan";
            user5.Email = "ugurxaslan@gmail.com";
            user5.UserName = "ugurxaslan";
        }

        User user6 = ObjectSpace.FirstOrDefault<User>(user =>
        user.UserName == "deliDerviş");
        if (user6 == null)
        {
            user6 = ObjectSpace.CreateObject<User>();
            user6.FirstName = "Derviş Ethem";
            user6.LastName = "Akpay";
            user6.Email = "dEthemAkpay@gmail.com";
            user6.UserName = "deliDerviş";
        }

        User user7 = ObjectSpace.FirstOrDefault<User>(user =>
        user.UserName == "makifff");
        if (user7 == null)
        {
            user7 = ObjectSpace.CreateObject<User>();
            user7.FirstName = "Mehmet Akif";
            user7.LastName = "Artun";
            user7.Email = "makifAbi@gmail.com";
            user7.UserName = "makifff";
        }

        User user8 = ObjectSpace.FirstOrDefault<User>(user =>
        user.UserName == "boboÇela");
        if (user8 == null)
        {
            user8 = ObjectSpace.CreateObject<User>();
            user8.FirstName = "Enes";
            user8.LastName = "Çela";
            user8.Email = "çelaProduction@gmail.com";
            user8.UserName = "boboÇela";
        }

        User user9 = ObjectSpace.FirstOrDefault<User>(user =>
        user.UserName == "İ-siz.ErlindJari");
        if (user9 == null)
        {
            user9 = ObjectSpace.CreateObject<User>();
            user9.FirstName = "Erlindi";
            user9.LastName = "Isaj";
            user9.Email = "dobraçCity@erlind.isaj.com";
            user9.UserName = "İ-siz.ErlindJari";
        }


        Post post1 = ObjectSpace.FirstOrDefault<Post>(post1 =>
        post1.Content == "Hello World!" && post1.Location == "Vranjska");
        if (post1 == null)
        {
            post1 = ObjectSpace.CreateObject<Post>();
            post1.CreateTime = new DateTime(2001, 12, 4);
            post1.Content = "Hello World!";
            post1.Location = "Vranjska";
            post1.Poster = ObjectSpace.FirstOrDefault<User>(user1 => user1.FirstName == "Leonit" && user1.LastName == "Shabani");
        }

        Page page1 = ObjectSpace.FirstOrDefault<Page>(page1 =>
        page1.PageName == "HLTV" && page1.FollowersCount == 500000);
        if (page1 == null)
        {
            page1 = ObjectSpace.CreateObject<Page>();
            page1.PageName = "HLTV";
            page1.FollowersCount = 500000;
            page1.ManagedBy.Add(ObjectSpace.FirstOrDefault<User>(user1 => user1.FirstName == "Leonit" && user1.LastName == "Shabani"));
            page1.ManagedBy.Add(ObjectSpace.FirstOrDefault<User>(user2 => user2.FirstName == "Besian" && user1.LastName == "Shabani"));
        }

        Page page2 = ObjectSpace.FirstOrDefault<Page>(page2 =>
        page2.PageName == "UEFA" && page2.FollowersCount == 10000000);
        if (page2 == null)
        {
            page2 = ObjectSpace.CreateObject<Page>();
            page2.PageName = "UEFA";
            page2.FollowersCount = 10000000;
            page2.ManagedBy.Add(ObjectSpace.FirstOrDefault<User>(user => user.FirstName == "Mehmet Akif"));
            page2.ManagedBy.Add(ObjectSpace.FirstOrDefault<User>(user => user.FirstName == "Derviş Ethem"));
            page2.ManagedBy.Add(ObjectSpace.FirstOrDefault<User>(user => user.FirstName == "Florian"));
        }

        Page page3 = ObjectSpace.FirstOrDefault<Page>(page3 =>
        page3.PageName == "Microsoft" && page3.FollowersCount == 10000000);
        if (page3 == null)
        {
            page3 = ObjectSpace.CreateObject<Page>();
            page3.PageName = "Microsoft";
            page3.FollowersCount = 10000000;
            page3.ManagedBy.Add(ObjectSpace.FirstOrDefault<User>(user => user.FirstName == "Uğur"));
            page3.ManagedBy.Add(ObjectSpace.FirstOrDefault<User>(user => user.FirstName == "Derviş Ethem"));
        }

        Page page4 = ObjectSpace.FirstOrDefault<Page>(page4 =>
        page4.PageName == "Pupil" && page4.FollowersCount == 20000);
        if (page4 == null)
        {
            page4 = ObjectSpace.CreateObject<Page>();
            page4.PageName = "Pupil";
            page4.FollowersCount = 20000;
            page4.ManagedBy.Add(ObjectSpace.FirstOrDefault<User>(user => user.FirstName == "Besian"));
        }

        Message message1 = ObjectSpace.FirstOrDefault<Message>(message1 => message1.Text == "Hello");
        if (message1 == null)
        {
            message1 = ObjectSpace.CreateObject<Message>();
            message1.SentTime = new DateTime(2023, 12, 14);
            message1.Text = "Hello";
            message1.Sender = ObjectSpace.FirstOrDefault<User>(user1 => user1.FirstName == "Leonit" && user1.LastName == "Shabani");
            message1.Receiver = ObjectSpace.FirstOrDefault<User>(user2 => user2.FirstName == "Besian" && user2.LastName == "Shabani");
        }

        Message message2 = ObjectSpace.FirstOrDefault<Message>(message2 => message2.Text == "Hi");
        if (message2 == null)
        {
            message2 = ObjectSpace.CreateObject<Message>();
            message2.SentTime = new DateTime(2023, 12, 14);
            message2.Text = "Hi";
            message2.Sender = ObjectSpace.FirstOrDefault<User>(user1 => user1.FirstName == "Besian" && user1.LastName == "Shabani");
            message2.Receiver = ObjectSpace.FirstOrDefault<User>(user2 => user2.FirstName == "Leonit" && user2.LastName == "Shabani");
        }

        Message message3 = ObjectSpace.FirstOrDefault<Message>(message3 => message3.Text == "Olsun be gülüm!");
        if (message3 == null)
        {
            message3 = ObjectSpace.CreateObject<Message>();
            message3.SentTime = new DateTime(2023, 12, 14);
            message3.Text = "Olsun be gülüm!";
            message3.Sender = ObjectSpace.FirstOrDefault<User>(user => user.FirstName == "Idris");
            message3.Receiver = ObjectSpace.FirstOrDefault<User>(user => user.FirstName == "Leonit");
        }

        Message message4 = ObjectSpace.FirstOrDefault<Message>(message => message.Text == "Nasip be Leo");
        if (message4 == null)
        {
            message4 = ObjectSpace.CreateObject<Message>();
            message4.SentTime = new DateTime(2023, 12, 14);
            message4.Text = "Nasip be Leo";
            message4.Sender = ObjectSpace.FirstOrDefault<User>(user => user.FirstName == "Mehmet Akif");
            message4.Receiver = ObjectSpace.FirstOrDefault<User>(user => user.FirstName == "Leonit");
        }

        Message message5 = ObjectSpace.FirstOrDefault<Message>(message => message.Text == "Oğlum sen salak mısın");
        if (message5 == null)
        {
            message5 = ObjectSpace.CreateObject<Message>();
            message5.SentTime = new DateTime(2023, 12, 14);
            message5.Text = "Oğlum sen salak mısın";
            message5.Sender = ObjectSpace.FirstOrDefault<User>(user => user.FirstName == "Uğur");
            message5.Receiver = ObjectSpace.FirstOrDefault<User>(user => user.FirstName == "Leonit");
        }

        Message message6 = ObjectSpace.FirstOrDefault<Message>(message => message.Text == "Je humb fare");
        if (message6 == null)
        {
            message6 = ObjectSpace.CreateObject<Message>();
            message6.SentTime = new DateTime(2023, 12, 14);
            message6.Text = "Je humb fare";
            message6.Sender = ObjectSpace.FirstOrDefault<User>(user => user.FirstName == "Enes");
            message6.Receiver = ObjectSpace.FirstOrDefault<User>(user => user.FirstName == "Leonit");
        }

        Message message7 = ObjectSpace.FirstOrDefault<Message>(message => message.Text == "Inxh leshit");
        if (message7 == null)
        {
            message7 = ObjectSpace.CreateObject<Message>();
            message7.SentTime = new DateTime(2023, 12, 14);
            message7.Text = "Inxh leshit";
            message7.Sender = ObjectSpace.FirstOrDefault<User>(user => user.FirstName == "Erlindi");
            message7.Receiver = ObjectSpace.FirstOrDefault<User>(user => user.FirstName == "Leonit");
        }

        Message message8 = ObjectSpace.FirstOrDefault<Message>(message => message.Text == "Hi Leo what is your name?");
        if (message8 == null)
        {
            message8 = ObjectSpace.CreateObject<Message>();
            message8.SentTime = new DateTime(2023, 12, 14);
            message8.Text = "Hi Leo what is your name?";
            message8.Sender = ObjectSpace.FirstOrDefault<User>(user => user.FirstName == "Derviş Ethem");
            message8.Receiver = ObjectSpace.FirstOrDefault<User>(user => user.FirstName == "Leonit");
        }




        ObjectSpace.CommitChanges(); // Uncomment this line to persist created objects.
    }
    public override void UpdateDatabaseBeforeUpdateSchema() {
        base.UpdateDatabaseBeforeUpdateSchema();
    }
}
