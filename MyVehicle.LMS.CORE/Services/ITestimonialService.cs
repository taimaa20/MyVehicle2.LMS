using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
  public  interface ITestimonialService
    {
        public bool DeleteTestimonial(Testimonial testimonial);
        public List<Testimonial> GetAllTestimonial();
        public bool InsertTestimonial(Testimonial testimonial);
        public bool UpdateTestimonial(Testimonial testimonial);
    }
}
