// See https://aka.ms/new-console-template for more information
using CareerCloud.ADODataAccessLayer;
using CareerCloud.Pocos;

Console.WriteLine("Hello, World!");

ApplicantJobApplicationPoco poco = new ApplicantJobApplicationPoco();
poco.Id = Guid.NewGuid();
poco.Applicant = Guid.NewGuid();
poco.Job = Guid.NewGuid();
poco.ApplicationDate = DateTime.Now;

ApplicantJobApplicationRepository repo = new ApplicantJobApplicationRepository();

ApplicantJobApplicationPoco[] pocos = new ApplicantJobApplicationPoco[1];

pocos[0] = poco;    

repo.Add(pocos);