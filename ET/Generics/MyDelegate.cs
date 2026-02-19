
// generic delegate:
// R → return type
// P → parameter type
// out R → can only be used as return (covariance)
// in P → can only be used as input (contravariance)
public delegate R MyDelegate<out R, in P>(P param);
