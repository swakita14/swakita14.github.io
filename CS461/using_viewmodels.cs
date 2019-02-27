public ActionResult Create(CreateContactViewModel model)
{
	// If model state is bad, return user to View where it should display validation errors
	if (!ModelState.IsValid) return View(model);

	//create user 
	string email = User.Identity.GetUserId();
	Debug.Write(email);

	// Model state was fine so get values from view model and assign to entity
	Contact newContact = new Contact()
	{
		ContactId = model.ContactId,
		Username = model.Username,
		FirstName = model.FirstName,
		LastName = model.LastName,
		Email = email,
		PhoneNumber = model.PhoneNumber,
		Address1 = model.Address1,
		Address2 = model.Address2,
		City = model.City,
		State = model.State,
		ZipCode = model.ZipCode
	};

	db.Contacts.Add(newContact);
	db.SaveChanges();
	return RedirectToAction("Index");
}