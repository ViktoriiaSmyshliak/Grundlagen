
// generic delegate:
// R → return type
// P → parameter type
// out R → can only be used as return (covariance)
// in P → can only be used as input (contravariance)
public delegate R MyDelegate<out R, in P>(P param);

// delegate for numeric transformation
public delegate double MatheHandler(double zahl);

// predicate delegate (returns bool)
public delegate bool DelegatePredicate(double d);

// projection delegate (returns transformed value)
public delegate uint DelegateProjection(double d);
