function customer(firstName, LastName)
{
    this.firstName = firstName;
    this.LastName = LastName;
    this.getFullName=function()
    {
        return this.firstName + " " +this.LastName;
    }
}
  