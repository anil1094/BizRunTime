var PragimTech = PragimTech || {};
PragimTech.TeamA1 = PragimTech.TeamA1 || {};


PragimTech.TeamA1.customer = function customer(firstName, LastName) {
    this.firstName = firstName;
    this.LastName = LastName;
    this.getFullName = function () {
        return this.firstName + " " + this.LastName;
    }
    return this;
}
