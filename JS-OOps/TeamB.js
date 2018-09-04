function customer(firstName, MiddleName,LastName) {
    this.firstName = firstName;
    this.LastName = LastName;
    this.MiddleName = MiddleName;
    this.getFullName = function () {
        return this.firstName + " " + this.MiddleName + " " + this.LastName;
    }
}
