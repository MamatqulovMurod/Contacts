﻿namespace ContactApi.Model
{
    public class AddContactRequest
    {
        public string FullName { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }

    }
}
