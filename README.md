# Virtual Contacts Application for STLCC IS 153

This is a Virtual Contact Management System made for Week 7 of STLCC IS 153. The first part of this was a console application for a lab. The second part included converting this to a WinForms application and submitting for the final exam.

## Program Spec (Collected from Lab 4B Part 1-3)

### Part 1: Structures

1. Define a structure called "Person" with the following fields:
    - Name (string)
    - Age (int)
    - PhoneNumber (string)
    - EmailAddress (string)
    - PreferredContactMethod (string)
2. Create a " CreatePerson " function that allows the user to input a name, age, phone number, email address, and preferred contact method (E = email address, P = phone number) and returns a Person object with the provided values.
3. In the main program, prompt the user to enter the details of two persons and create Person objects using the createPerson function.
    - Ensure users are providing a valid age. If not, display "Invalid input. Please enter a valid age."
    - Ensure users are providing a correct preferred method of contact. If not, display "Invalid input. Please enter 'E' for email address or 'P' for phone number."
4. Display the details of the two persons on the console.
    - Create a function "DisplayPersonDetails" to handle outputting the results on the screen.

### Part 2: Enumerated Types

1. Define an enumeration called "DayOfWeek" with the following values:
    - Sunday
    - Monday
    - Tuesday
    - Wednesday
    - Thursday
    - Friday
    - Saturday
2. Modify the Person structure from Part 1 to include an additional field called "DayOfBirth" of type DayOfWeek.
3. Update the function called "DisplayPersonDetails" that takes a Person object as input and displays all the fields of the person, including the day of birth.
4. In the main program, prompt the user to enter the details of a person and assign a day of birth using the DayOfWeek enumeration.
    - Ensure users are re-prompted if they enter the information incorrectly.
5. Create a Person object using the entered details and display the person's details using the DisplayPersonDetails function.

### Part 3: Dictionaries

1. Modify the Person structure from Part 1 to include an additional field called "StreetAddress" of type string.
2. Create an empty dictionary called "Contacts" to store contact information. This should be implemented in the Program class before the Main() method. This dictionary should contain the person's name as the key and the "Person" object as the value.
3. Modify your main program prompts to include the Virtual Contact Management System welcome message with a menu with options to create a new contact, view all contacts, or search for a contact.
4. This menu should be re-prompted until the user can exit the program.
    - The create new contact menu option should call the "CreateNewContact" method that uses the previously designed CreatePerson() method to create a new contact. If the contact was created successfully, the message "Contact created successfully!" is shown; otherwise, "A contact with the same name already exists. Contact not created." is shown.
        - Update the CreatePerson() method to display "Enter the details for a new contact:" instead of "Enter the details for a person:"
    - The view all contacts option should call the "ViewAllContacts" method that uses the previously designed DisplayPersonDetails() method to display a list of all the contacts in the dictionary or show a message "No contacts available."
        - When listing all contacts, the heading "All Contacts" should be shown before the contacts listing.
    - The search for a contact option should call the "SearchContact" method to allow users to enter a contact name and see the full contact details. If the search returns no results, the message "Contact not found." should be displayed.
    - If the user enters an invalid menu choice, then the message "Invalid choice. Please enter a valid option (1-4)."
    - The message "Exiting program..." should display when the user chooses to exit the program.
5. Update the DisplayPersonDetails to show "Contact Details" instead of "Person Details."
    - This method should also be updated to print out the street address.


## Lab 4B

Unfortunately I initialized this repo after completeing this. So the specifc solutions for parts 1-3 of the lab are not availble here. However, I do have them stored in a seperate private repo for this class if needed.

## Final Exam

WinForms application for the Virtual Contact Management System designed in the lab during week 7. Refer to the labs to ensure all functionality is included.

### Requirements

1. Winforms (.NET Core)
2. User Interface
	- [ ] Label or title of the application name "Virtual Contact Management System".
	- Buttons for:
		- [ ] "Create New Contact"
		- [ ] "View All Contacts"
		- [ ] "Search Contact"
		- [ ] "Exit"
	- (Not Required) Any other controls and layouts to enhance user expierence.
3. Functionality
	- Create New Contact
		- [ ] On click, open "NewContactForm"
		- NewContactForm
			- [ ] "Add Contact" button
				- [ ] Input validation
				- [ ] Create instance of "Contact" struct
				- [ ] Add to contact list and close form
	- View All Contacts
		- [ ] On click, open "ViewContactsForm"
		- ViewContactsForm
			- [ ] ListView or GridView of *all* "Contact" details
			- [ ] Display "No Saved Contacts" if empty
	- Search Contact
		- [ ] On click, open "SearchContactForm"
		- SearchContactForm
			- [ ] "txtContactName" to search for a contact by name
			- [ ] If found, display matching contact in "ContactForm"
			- [ ] If no match found, display MessageBox "No Contact found matching that name."
	- Exit
		- [ ] On click, Close application.
		- [ ] (Optional) Confirmation before exiting.
4. [ ] Test and debug