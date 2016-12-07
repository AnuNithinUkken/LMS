﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LMS_WebAPI_ServiceHelpers;
using LMS_WebAPI_Domain;

namespace EmployeeLeaveManagementWebAPI.Controllers
{
    public class EmployeeLeaveTransController : ApiController
    {

        // GET api/values
        public List<EmployeeLeaveTransactionModel> Get()
        {
            EmployeeLeaveTransactionManagement ELTM = new EmployeeLeaveTransactionManagement();
            var res=ELTM.GetEmployeeLeaveTransaction();

            return res;
            
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }
    }
}
