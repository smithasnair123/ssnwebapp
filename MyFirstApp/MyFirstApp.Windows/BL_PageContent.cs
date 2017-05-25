using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class BL_PageContent
    {
        public static string VarOutput { get; set; }
        public static string courseCode_var { get; set; }
        public static string courseTitle_var { get; set; }
        public static string courseDesc_var { get; set; }
        public static string courseCredits_str { get; set; }
        public static string coursePreReqs_str { get; set; }
        public static string CreatedBy { get; set; }


        public static string image_var { get; set; }
        public static string name_var { get; set; }
        public static string course_var { get; set; }
        public static string email_var { get; set; }
        public static string phone_var { get; set; }






        public static void Course1()
        {
            string[] names = new string[5] { "CDA3315C", "Fundamentals of Enterprise Architecture", "This course is the study of business enterprise analysis, design, planning and implementation. It places focus on working with stakeholders, modeling business data flows and interfaces, determining the information security risk for an organization, and re - engineering business processes.Topics include current software development methodologies, business process modeling, and enterprise information security methodologies.", "4", "Fundamentals of Programming" };
            courseCode_var = names[0];
            courseTitle_var = names[1];
            courseDesc_var = names[2];
            courseCredits_str = names[3];
            coursePreReqs_str = names[4];
        }
        public static void Course2()
        {
            string[] names = new string[5] { "MAN 3504", "Operations Managament", "In this course students examine the operations function of managing people, information, technology, materials, and facilities to produce goods and services. Specific areas covered will include: designing and managing operations; purchasing raw materials; controlling and maintaining inventories; and producing good or services that meet customers' expectations. Quantitative modeling will be used for solving business problems.", "3", "Fundamentals of Cloud Computing" };
            courseCode_var = names[0];
            courseTitle_var = names[1];
            courseDesc_var = names[2];
            courseCredits_str = names[3];
            coursePreReqs_str = names[4];
        }
        public static void Course3()
        {
            string[] names = new string[5] { "CDA 3428CC", "Distributed Application Architecture", "This course is the study of the design and use of distributed software applications as part of a enterprise architecture in a typical business. It places focus on the software development process, business process analysis, and generating functional requirements for business technology. ", "5", "Fundamentals of Programming" };
            courseCode_var = names[0];
            courseTitle_var = names[1];
            courseDesc_var = names[2];
            courseCredits_str = names[3];
            coursePreReqs_str = names[4];
        }
        public static void Course4()
        {
            string[] names = new string[5] { "CIS 3801C", "Fundamentals of Mobile Web Application Development", "This course presents the fundamentals of mobile web applications development. It places a focus on implementing well-defined mobile application standards, while designing a mobile application as a business solution to a real business scenario.Topics include mobile application standards, selecting appropriate content adaptation strategies, and following the system's development life cycle to plan, design, test, and deploy a mobile application.", "5", "Fundamentals of Programming" };
            courseCode_var = names[0];
            courseTitle_var = names[1];
            courseDesc_var = names[2];
            courseCredits_str = names[3];
            coursePreReqs_str = names[4];
        }
        public static void Course5()
        {
            string[] names = new string[5] { "CIS 4655C", "Advanced Mobile Web Application Development", "This course will prepare students to create more advanced mobile applications that interact with cloud-based databases.e", "5", "Mobile Web Application Development" };
            courseCode_var = names[0];
            courseTitle_var = names[1];
            courseDesc_var = names[2];
            courseCredits_str = names[3];
            coursePreReqs_str = names[4];
        }
        public static void Course6()
        {
            string[] names = new string[5] { "GEB 3422", "Business Project Management", "This course is a study of the characteristics and functions of project management, team building, and facilitation. It places focus on project planning, scope, scheduling, and controlling of projects through completion. It reinforces and builds upon skills and knowledge students have learned in all of the various disciplines within the Business curriculum. ", "5", "Fundamentals of Programming" };
            courseCode_var = names[0];
            courseTitle_var = names[1];
            courseDesc_var = names[2];
            courseCredits_str = names[3];
            coursePreReqs_str = names[4];
        }
        public static void Course7()
        {
            string[] names = new string[5] { "COP3488C", "Emerging Trends in Technology", "This course is the study of emerging technologies. It places focus on technology impact on business and society in general. Topics include the relationship between emerging technologies and business opportunities, analysis of costs and savings of implementing particular technologies, legal and ethical issues affecting technology, challenges of adapting new technologies, and impacts of technology.", "5", "None" };
            courseCode_var = names[0];
            courseTitle_var = names[1];
            courseDesc_var = names[2];
            courseCredits_str = names[3];
            coursePreReqs_str = names[4];
        }
        public static void Course8()
        {
            string[] names = new string[5] { "CIS 3917C", "Fundamentals of Distributed Database Management", "This course is the study of distributed databases and the technical architecture they reside on. It places focus on geographically separated databases where through database replication, end users experience database transparency. Topics include the differences between distributed databases and stand-alone database management systems, scalability, replication, and overall high availability concepts as they relate to distributed databases. ", "5", "Fundamentals of Programming" };
            courseCode_var = names[0];
            courseTitle_var = names[1];
            courseDesc_var = names[2];
            courseCredits_str = names[3];
            coursePreReqs_str = names[4];
        }
        public static void Course9()
        {
            string[] names = new string[5] { "COP3488C", "Introduction to Business Intelligence", "This course is Business Intelligence", "3", "Fundamentals of Programming" };
            courseCode_var = names[0];
            courseTitle_var = names[1];
            courseDesc_var = names[2];
            courseCredits_str = names[3];
            coursePreReqs_str = names[4];
        }
        public static void Course10()
        {
            string[] names = new string[5] { "COP3488D", "Database Implementation Strategies for Programmers", "The focus of this course is to provide programmers the information necessary to interface mobile software applications with cloud-based distributed databases.Topics include a review of database fundamentals, database connectivity, query optimization, and the use of application program interfaces(APIs) as they relate to specific vendor databases.This course is Business Intelligence", "5", "Fundamentals of Programming" };
            courseCode_var = names[0];
            courseTitle_var = names[1];
            courseDesc_var = names[2];
            courseCredits_str = names[3];
            coursePreReqs_str = names[4];
        }
        public static void Course11()
        {
            string[] names = new string[5] { "CIS 4836C", "Web Analytics", "This course is the study of contemporary business analytics tools. It places a focus on determining the most appropriate product or technology for building data visualizations and dashboards.Topics include identifying analytical tools, highlighting various input and output data formats, identifying different types of data visualizations, and constructing business - oriented dashboards. ", "4", "None" };
            courseCode_var = names[0];
            courseTitle_var = names[1];
            courseDesc_var = names[2];
            courseCredits_str = names[3];
            coursePreReqs_str = names[4];
        }
        public static void Course12()
        {
            string[] names = new string[5] { "COP3488C", "Fundamentals of Cloud Computing", "This course will introduce students to various technologies and services utilized in cloud computing. The course will focus on practical application of cloud deployment methodologies. Topics include the evolution of cloud computing technology, examination of cloud deployment and cloud service models, and designing a cloud computing strategy to meet specific business needs.", "3", "None" };
            courseCode_var = names[0];
            courseTitle_var = names[1];
            courseDesc_var = names[2];
            courseCredits_str = names[3];
            coursePreReqs_str = names[4];
        }
        public static void Course13()
        {
            string[] names = new string[5] { "CTS 4623C", "Advanced Cloud Computing", "This course will provide students with an in-depth understanding of computing technologies and services for enterprise level application deployment projects. The course will focus on practical aspects of cloud based application architecture and deployment methodologies, using the Microsoft Azure cloud platform. ", "4", "None" };
            courseCode_var = names[0];
            courseTitle_var = names[1];
            courseDesc_var = names[2];
            courseCredits_str = names[3];
            coursePreReqs_str = names[4];
        }
        public static void Course14()
        {
            string[] names = new string[5] { "CIS 4910C", "Computer Science Capstone", "This course is the culmination of the diverse skill set previously gained throughout the program. It places focus on project management skills, communication, and critical thinking as they relate to constructing an end-to-end technical solution. This course will incorporate a different project focus each term where students will collaborate in the development of a mobile/cloud application system.", "3", "Technology Bachelor's student in final term" };
            courseCode_var = names[0];
            courseTitle_var = names[1];
            courseDesc_var = names[2];
            courseCredits_str = names[3];
            coursePreReqs_str = names[4];
        }


        //Faculty Details

        public static void Faculty1()
        {
            string[] Fnames = new string[5] { "/Images/mrSinclair.png", "Thomas Sinclair", "COP3488C - Universal Windows App Development", "thomas.sinclair@rasmussen.edu", "(952) 314-3920" }; 
            image_var = Fnames[0];
            name_var = Fnames[1];
            course_var = Fnames[2];
            email_var = Fnames[3];
            phone_var = Fnames[4];
        }

        public static void Faculty2()
        {
            string[] Fnames = new string[5] { "/Images/Alex.jpg", "Alex", "CDA 3315C - Fundamentals of Programming", "alex@rasmussen.edu", "(703) 383-4577" };
            image_var = Fnames[0];
            name_var = Fnames[1];
            course_var = Fnames[2];
            email_var = Fnames[3];
            phone_var = Fnames[4];
        }
        public static void Faculty3()
        {
            string[] Fnames = new string[5] { "/Images/john.png", "John", "COP3455C - Business Intelligence", "johnr@rasmussen.edu", "(786) 314-3220" };
            image_var = Fnames[0];
            name_var = Fnames[1];
            course_var = Fnames[2];
            email_var = Fnames[3];
            phone_var = Fnames[4];
        }
        public static void Faculty4()
        {
            string[] Fnames = new string[5] { "/Images/veira.jpg", "Dawn Veira", "COP3322D - Advanced Cloud Computing", "dawnveira@rasmussen.edu", "(952) 736-234" };
            image_var = Fnames[0];
            name_var = Fnames[1];
            course_var = Fnames[2];
            email_var = Fnames[3];
            phone_var = Fnames[4];
        }
    }
}
