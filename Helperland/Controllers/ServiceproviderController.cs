﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.Json;
using System.Threading.Tasks;
using Helperland.Data;
using Helperland.Models;
using Helperland.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Helperland.Controllers
{
    public class ServiceproviderController : Controller
    {
        private readonly HelperlandContext _helperlandContext;
        public ServiceproviderController(HelperlandContext helperlandContext)
        {
            _helperlandContext = helperlandContext;
        }

        public IActionResult Upcoming_service()
        {
            return View();
        }

        [HttpPost]
        public string GetNewServiceRequest(CustomerServiceNewRequest customerServiceNewRequest)
        {
            User user = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("CurrentUser"));
            int userid = user.UserId;
            var newservice = (from sr in _helperlandContext.ServiceRequests
                              join u in _helperlandContext.Users on sr.UserId equals u.UserId
                              join add in _helperlandContext.ServiceRequestAddresses on sr.ServiceRequestId equals add.ServiceRequestId
                              where sr.Status == 1 
                              select new
                              {
                                  RequestId = sr.ServiceRequestId,
                                  ServiceStartDate = sr.ServiceStartDate.ToString("d"),
                                  ServiceStartTime = sr.ServiceStartDate.ToString("HH:mm"),
                                  CustomerName = u.FirstName + " " + u.LastName,
                                  ServiceTotalHour = sr.ServiceHours + sr.ExtraHours,
                                  TotalCost = sr.TotalCost,
                                  SubTotal = sr.SubTotal,
                                  AddressLine1 = add.AddressLine1,
                                  AddressLine2 = add.AddressLine2,
                                  City = add.City,
                                  PostalCode = add.PostalCode,
                                  Mobile = add.Mobile,
                              }).ToList();
            return JsonSerializer.Serialize(newservice);
        }

        [HttpPost]
        public string AcceptServiceRequest(int servicerequestId, string? comments)
        {
            Console.WriteLine("uuuuuuuuuuuuuuuuuuuuuuuuuuuuu");
            User u = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("CurrentUser"));
            int? userId = u.UserId;


            if (userId != null)
            {
                ServiceRequest request = _helperlandContext.ServiceRequests.FirstOrDefault(x => x.ServiceRequestId == servicerequestId);
                request.Comments = comments;
                request.Status = 4;
                request.ServiceProviderId = userId;
                request.SpacceptedDate = DateTime.Now;
                _helperlandContext.ServiceRequests.Update(request);
                _helperlandContext.SaveChanges();
                return "true";
            }
            return "false";
        }

        [HttpPost]
        public string GetUpcomingServiceRequest(CustomerServiceNewRequest customerServiceNewRequest)
        {
            User user = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("CurrentUser"));
            int userid = user.UserId;
            var upcomingservice = (from sr in _helperlandContext.ServiceRequests
                                   join u in _helperlandContext.Users on sr.UserId equals u.UserId
                                   join add in _helperlandContext.ServiceRequestAddresses on sr.ServiceRequestId equals add.ServiceRequestId
                                   where sr.Status == 4
                                   select new
                                   {

                                       RequestId = sr.ServiceRequestId,
                                       ServiceStartDate = sr.ServiceStartDate.ToString("d"),
                                       ServiceStartTime = sr.ServiceStartDate.ToString("HH:mm"),
                                       CustomerName = u.FirstName + " " + u.LastName,
                                       ServiceTotalHour = sr.ServiceHours + sr.ExtraHours,
                                       TotalCost = sr.TotalCost,
                                       Distance = sr.Distance,

                                       AddressLine1 = add.AddressLine1,
                                       AddressLine2 = add.AddressLine2,
                                       City = add.City,
                                       PostalCode = add.PostalCode,
                                       Mobile = add.Mobile,
                                       Email = add.Email,
                                   }).ToList();

            return JsonSerializer.Serialize(upcomingservice);

        }

        [HttpPost]
        public string CancelUpcomingServiceRequest(int servicerequestId, ServiceRequest s)
        {

            User u = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("CurrentUser"));
            int? userId = u.UserId;

            if (userId != null)
            {
                ServiceRequest request = _helperlandContext.ServiceRequests.FirstOrDefault(x => x.ServiceRequestId == servicerequestId);
                request.Comments = s.Comments;
                request.Status = 3;
                _helperlandContext.ServiceRequests.Update(request);
                _helperlandContext.SaveChanges();

                return "true";

            }
            return "false";
        }

        [HttpPost]
        public string CompleteUpcomingServiceRequest(int servicerequestId, ServiceRequest s)
        {

            User u = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("CurrentUser"));
            int? userId = u.UserId;
            string Name = u.FirstName + " " + u.LastName;

            if (userId != null)
            {
                ServiceRequest request = _helperlandContext.ServiceRequests.FirstOrDefault(x => x.ServiceRequestId == servicerequestId);
                if (request.ServiceProviderId != null)
                {
                    var SP = _helperlandContext.Users.Where(u => u.UserId == request.ServiceProviderId).Select(u => new { u.Email, u.FirstName, u.LastName }).FirstOrDefault();
                    if (SP != null)
                    {
                        Mail mail = new Mail();
                        string Email = SP.Email;
                        string name = SP.FirstName + " " + SP.LastName;
                        string Subject = "Service Completed";
                        string Body =
                        "Hello,\n" +
                        SP.FirstName + " " + SP.LastName + "\n\n" +
                        "your service has been completed" + "\n" +
                        Name + " please check   \n" +
                        "Service ID: " + servicerequestId;

                        MailMessage msg = new MailMessage();
                        msg.To.Add(Email);
                        msg.Subject = Subject;
                        msg.Body = Body;
                        msg.From = new MailAddress("sirijery@gmail.com");
                        msg.IsBodyHtml = true;
                        SmtpClient setup = new SmtpClient("smtp.gmail.com");
                        setup.Port = 587;
                        setup.UseDefaultCredentials = true;
                        setup.EnableSsl = true;
                        setup.Credentials = new System.Net.NetworkCredential("sirijery@gmail.com", "siri@90543");
                        setup.Send(msg);

                    }
                }
                var customer = _helperlandContext.Users.Where(u => u.UserId == request.UserId).Select(u => new { u.Email, u.FirstName, u.LastName }).FirstOrDefault();
                if (customer != null)
                {
                    Mail mail = new Mail();
                    string Email = customer.Email;
                    string name = customer.FirstName + " " + customer.LastName;
                    string Subject = "Service Completed";
                    string Body =
                    "Hello,\n" +
                        "your service has been completed" + "\n" +
                        Name + " please check your  \n" +
                        "Service ID: " + servicerequestId + " and give rating  \n";
                    MailMessage msg = new MailMessage();
                    msg.To.Add(Email);
                    msg.Subject = Subject;
                    msg.Body = Body;
                    msg.From = new MailAddress("sirijery@gmail.com");
                    msg.IsBodyHtml = true;
                    SmtpClient setup = new SmtpClient("smtp.gmail.com");
                    setup.Port = 587;
                    setup.UseDefaultCredentials = true;
                    setup.EnableSsl = true;
                    setup.Credentials = new System.Net.NetworkCredential("sirijery@gmail.com", "siri@90543");
                    setup.Send(msg);
                }

                request.Comments = s.Comments;
                request.Status = 2;
                _helperlandContext.ServiceRequests.Update(request);
                _helperlandContext.SaveChanges();

                return "true";

            }
            return "false";
        }

        [HttpPost]
        public string GetServiceHistory(CustomerServiceNewRequest customerServiceNewRequest)
        {
            User user = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("CurrentUser"));

            int userid = user.UserId;
            var servicehistory = (from sr in _helperlandContext.ServiceRequests
                                  join u in _helperlandContext.Users on sr.UserId equals u.UserId
                                  join add in _helperlandContext.ServiceRequestAddresses on sr.ServiceRequestId equals add.ServiceRequestId
                                  where sr.Status == 2
                                  select new
                                  {

                                      RequestId = sr.ServiceRequestId,
                                      ServiceStartDate = sr.ServiceStartDate.ToString("d"),
                                      ServiceStartTime = sr.ServiceStartDate.ToString("HH:mm"),
                                      CustomerName = u.FirstName + " " + u.LastName,
                                      ServiceTotalHour = sr.ServiceHours + sr.ExtraHours,
                                      TotalCost = sr.TotalCost,
                                      Distance = sr.Distance,

                                      AddressLine1 = add.AddressLine1,
                                      AddressLine2 = add.AddressLine2,
                                      City = add.City,
                                      PostalCode = add.PostalCode,
                                      Mobile = add.Mobile,
                                  }).ToList();

            return JsonSerializer.Serialize(servicehistory);
        }

        [HttpPost]
        public string GetMyRating(CustomerServiceNewRequest customerServiceNewRequest)
        {
            User user = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("CurrentUser"));

            int userid = user.UserId;
            var rating = (from rate in _helperlandContext.Ratings
                          join u in _helperlandContext.Users on rate.RatingFrom equals u.UserId
                          join sr in _helperlandContext.ServiceRequests on rate.ServiceRequestId equals sr.ServiceRequestId
                          where rate.RatingTo == userid
                          select new
                          {

                              RequestId = sr.ServiceRequestId,
                              ServiceStartDate = sr.ServiceStartDate.ToString("d"),
                              ServiceStartTime = sr.ServiceStartDate.ToString("HH:mm"),
                              CustomerName = u.FirstName + " " + u.LastName,
                              ServiceTotalHour = sr.ServiceHours + sr.ExtraHours,
                              TotalCost = sr.TotalCost,
                              Distance = sr.Distance,

                              Ratings = rate.Ratings,
                              Comments = rate.Comments,

                          }).ToList();

            return JsonSerializer.Serialize(rating);
        }

        [HttpPost]
        public string GetBlockCustomer(string s)
        {
            User user = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("CurrentUser"));
            int userid = user.UserId;
            var block = (from sr in _helperlandContext.ServiceRequests
                         join u in _helperlandContext.Users on sr.UserId equals u.UserId

                         where sr.ServiceProviderId == userid
                         select new
                         {
                             RequestId = sr.UserId,
                             CustomerName = u.FirstName + " " + u.LastName,
                             IsBlocked = _helperlandContext.FavoriteAndBlockeds.Where(x => x.UserId == userid && x.TargetUserId == sr.UserId).Select(x => x.IsBlocked).FirstOrDefault()
                         }).Distinct().ToList();

            return JsonSerializer.Serialize(block);
        }

        public string BlockCustomerService(int BlockUserId , bool IsBlocked)
        {
            User u = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("CurrentUser"));
            int? userid = u.UserId;

            if (userid != null)
            {
              FavoriteAndBlocked favoriteAndBlocked = _helperlandContext.FavoriteAndBlockeds.Where(c => c.TargetUserId == BlockUserId && c.UserId==userid).FirstOrDefault();
                if (favoriteAndBlocked != null)
                {
                    favoriteAndBlocked.IsBlocked = IsBlocked;
                    _helperlandContext.FavoriteAndBlockeds.Update(favoriteAndBlocked);
                    _helperlandContext.SaveChanges();
                  
                }
                else
                {
                    FavoriteAndBlocked favoriteAndBlocked1 = new FavoriteAndBlocked();
                    favoriteAndBlocked1.UserId = u.UserId;
                    favoriteAndBlocked1.TargetUserId = BlockUserId;
                    favoriteAndBlocked1.IsBlocked = IsBlocked;
                    _helperlandContext.FavoriteAndBlockeds.Add(favoriteAndBlocked1);

                }

            }
            return "true";
        }

       





        public string GetUserDetails(string s)
        {
            User user = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("CurrentUser"));

            var currentProviderDetails = _helperlandContext.Users.Where(u => u.UserId == user.UserId).FirstOrDefault();
            Console.WriteLine(currentProviderDetails.FirstName);
            return JsonSerializer.Serialize(currentProviderDetails);
        }
        public string GetAddressDetails(string s)
        {
            User user = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("CurrentUser"));
            var currentProviderAddressDetails = _helperlandContext.UserAddresses.Where(u => u.UserId == user.UserId).FirstOrDefault();
            return JsonSerializer.Serialize(currentProviderAddressDetails);
        }

        public string SaveDetails(SPsavedetails sPsavedetails)
        {
            User u = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("CurrentUser"));
            int? userid = u.UserId;
            if (userid != null)
            {
                User user = _helperlandContext.Users.FirstOrDefault(x => x.UserId == userid);
                UserAddress userAddress = new UserAddress();
                user.FirstName = sPsavedetails.FirstName;
                user.LastName = sPsavedetails.LastName;
                user.Email = sPsavedetails.Email;
                user.Mobile = sPsavedetails.Mobile;

                //UserAddress userAddress = _helperlandContext.UserAddresses.Where(x => x.AddressId == sPsavedetails.AddressId).FirstOrDefault();
                userAddress.AddressLine1 = sPsavedetails.AddressLine1;
                userAddress.AddressLine2 = sPsavedetails.AddressLine2;
                userAddress.City = sPsavedetails.City;
                userAddress.PostalCode = sPsavedetails.PostalCode;
                userAddress.Mobile = sPsavedetails.Mobile;

                _helperlandContext.Users.Update(user);
                _helperlandContext.SaveChanges();
            }
            else
            {
                return "something wrong please check";
            }



            return "true";
        }

        //public string AddproviderAddress(User user)
        //{
        //    User u = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("CurrentUser"));
        //    int? userid = u.UserId;
        //    if (userid != null)
        //    {
        //        UserAddress serviceadd = new UserAddress();
        //        serviceadd.UserId = (int)userid;
        //        serviceadd.AddressLine1 = user.AddressLine1;
        //        serviceadd.AddressLine2 = user.AddressLine2;
        //        serviceadd.City = user.City;
        //        serviceadd.Mobile = user.Mobile;
        //        serviceadd.PostalCode = user.PostalCode;
        //        var serviceaddResult = _helperlandContext.UserAddresses.Add(serviceadd);
        //        _helperlandContext.SaveChanges();
        //        return "true";
        //    }
        //    return "false";
        //}



        public string GetStoredPassword(string StoredPassword)
        {
            User user = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("CurrentUser"));


            var s = _helperlandContext.Users.Where(x => x.UserId == user.UserId).FirstOrDefault();
            return JsonSerializer.Serialize(s);

        }
        public string ChangePassword(Login changepassword)
        {
            User u = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("CurrentUser"));
            int? userid = u.UserId;
            if (userid != null)
            {
                User user = _helperlandContext.Users.Where(x => x.UserId == userid && x.Password == changepassword.Password).FirstOrDefault();

                user.Password = changepassword.NewPassword;

                _helperlandContext.Users.Update(user);
                _helperlandContext.SaveChanges();
                return "true";
            }
            else
            {
                return "false";
            }


        }
    }
}
