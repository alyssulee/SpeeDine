# SpeeDine (Group 10) CPSC 481

## Authors
1. Alyssa Lee (alyssa.lee1@ucalgary.ca)
2. Shafin Kheraj (shafin.kheraj1@ucalgary.ca)
3. Rachael Nguyen (rachael.nguyen@ucalgary.ca)
4. Lana Nieves (lanaisabella.nieves@ucalgary.ca)
5. Suvrat Kumra (suvrat.kumra@ucalgary.ca, https://www.linkedin.com/in/suvrat-kumra-420017193/)

## Set-up
Please ensure that your version of Visual Studio 2022 has the "ASP.NET and web development" package and can run .NET 5.

## What is SpeeDine?
SpeeDine is a web application that a restaurant can use to give its patrons an fast, efficient, and fun dining experience! Instead of using paper menus and having to order through a waiter, guests can use SpeeDine to have all the control in the palm on their hands! To access SpeeDine, guests can scan the QR code at their table on their own devices. Each device will be tied to that specific guest and to that specific table. SpeeDine gives them the ability to look through the menu, order items, split the bill, request payment, call the waiter, and more! 

## Features
- Website that can be accessed from any mobile device
- Multiple devices interacting with features 
- Convenient nav bar that directs to all the important pages
- Help buttons available for every page
- View menu items by category
- Easily sort through menu items by dietary preference
- Easily compare menu items with a "Pinned" feature
- Easily choose a side and make a special request when ordering
- Edit menu items already added to the Cart
- Instantly place orders
- View the status of orders (Pending Order, Waiting, Delivered)
- Call the waiter for any help at all!
- Ability to choose between requesting the entire bill or splitting it amongst guests
- Easy-to-use interface for splitting the bill -- simply pick the items you'd like to pay for! The cost of items can be shared by several people
- Convenient review screen that allows guests to share their thoughts while allowing the restaurant to gain feedback on their services

## Walkthrough
### Welcome screen, "/"
1. Enter your name into the text box to get started.
2. Click "Continue to Menu".
### Menu, "/menu/Popular"
1. You're automatically redirected to the Menu. Note that you're under the "Menu" section in the navigation bar.
2. In the menu, you're automatically redirected to the "Popular" section. Feel free to navigate through the categories at the top (left to right scrolling).
#### Using "Sort by Diet" feature
Use this feature to easily find foods that fit your diet.
1. Click the filter icon next to "Sort By Diet".
2. In the pop-up menu, select the diets you'd like to filter for (selecting several is permitted).
3. In the pop-up menu, select "Clear All" if you'd like to clear what you've selected.
4. Click the filter icon again to remove the pop-up menu.
5. On the menu screen, the items that fit ALL the criteria you've selected will appear. If none have appeared, the error message "Sorry, there are no menu items that match" will appear instead, telling you that there are no items that fit ALL the criteria you've selected.
#### Using the "Pinned" feature
Use this feature to easily compare items on the menu by shortlisting them, regardless of their section. 
1. For each menu item, there is a pin icon on the bottom-right. 
2. Click the pin icon to "pin" the item.
3. Navigate to the "Pinned" section in the categories bar. 
4. The items you've pinned will be there, allowing you to easily compare them.
#### Adding an item to the Cart
1. Click any menu item that you'd like to add to the Cart (and thus, eventually order).
2. A pop-up will appear of the item's details, sides (if any), Special Instructions text box, and quantity selector.
3. If the item comes with sides, click the radio button for the side you'd like to order; this mandatory.
4. If you'd like, enter any special instructions in the textbox.
5. You can duplicate order (with that chosen side and the given instructions), increase the quantity using the "+" button. Similarly, you can decrease the quantity (to 1, minimum) by using the "-" button. 
6. To add this item to the Cart, click the "Add to Cart" button. To instead cancel this entire process, scroll back up and click the "Back to Menu button". Either way, you'll be redirected back to the Menu page.
8. If you added the item to the Cart, the "Cart" button at the bottom of the menu page should say "Cart (1)" now. Click it to see the item you ordered!

(Instructions for README)
What cases/functions were implemented? What data should be entered at which times? To ensure that we don't miss any of the best features of your system you should word your instructions as an exact walkthrough of what should be typed and what controls should be set to what values. Everything must run from the installation directory (Hint: use App. Path. This means that you should use relative rather than absolute paths.
