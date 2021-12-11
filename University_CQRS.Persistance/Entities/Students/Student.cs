﻿
public class Student : EntityBase
{
    public virtual string Name { get; set; }
    public virtual string Email { get; set; }

    public virtual IList<Enrollment> Enrollments { get; set; }
    public virtual IList<Disenrollment> Disenrollments { get; set; }
}
