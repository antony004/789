Set Up:
On the Console, run "cd 789" and then "dotnet run seeddata". This Creates the database and populates it with values for a referral code.
{
1. HNCKeg8Hjc9VkZA/
2. TIAkcMjvbEWhr7AM
3. tZiI/xPJDNcZ9TYu
4. nk/b8kAufpOTrDOz
}
Following the register link prompts for a referral code before registration can be completed.
An external Email Service may be configured later for verification


Notes:
1. Regular html pages have been converted to ".razor" files in the pages folder, regular html is still used, but it provides opportunities for running back-end code on the same page.
2. NavMenu and general layout exist in the shared folder.
3. Css files and Images have been moved to the wwroot folder, the way they are used/called has not changed.
4. The Database has been set up to accomodate the quiz storage, further improvements will require a sample to test on.
5. All pages relating to Authorization/authentication are in the Areas Folder.
6. The Referral Code Generation and verification file is in the data folder.