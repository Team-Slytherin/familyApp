#Finishing Things Project

##Requirements

- Use WebApi
- Use Identity Framework
	- Choose Single User Authentication on the scaffolding screen
- Use Entity Framework
	- Remember, you can use the Identity Framework DbContext (`ApplicationDbContext`)
		- You can move this class around to a different folder (like your `DAL` folder)
	- The `ApplicationUser` class is the Model for your users.  If you want to have custom properties, add them to that class
- Use Angular
	- Users can register
	- Users can login
	- Users can logout
	- Users can access crud-ish, restricted (use the `[Authorize]` attribute) Api endpoints for one Model
		- Can be your user profile
		- Doesn't have to be.
- Make it not ugly
	- Bootstrap is included in the project by default
	- Brush up your css skills