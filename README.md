# ConversationHelperBot
Conversation helper bot for Telegram




## Version 2018.5

### [Backend]
:heavy_plus_sign: now currentversion is version with major version = int32 max  
:hammer: fixed sorting of changes for "Save" feature  
:hammer: fixed bugs with product parts on product creating  
:hammer: fixed bug with product accessibility after its removing  
:hammer: fixed partially txt export  
:heavy_minus_sign: prevent version restoring if same version already exists  
:heavy_minus_sign: cnahged appearance of changes in generated files  
> changes separated by builds, added versions names, date of version creating (date of last change, irl)  

:heavy_minus_sign: removed old Api, due to which the server slows down  

### [Common]
:heavy_plus_sign: first letter of each change exports as lowercase now  
:heavy_plus_sign: added grouping by minor/build version on saving  
:heavy_plus_sign: fixed work with roles  
:heavy_plus_sign: currentVersion will be created on creating change or getting changelist  
:hammer: fixed bug due to which several were created Current version  
:heavy_minus_sign: isStable has been splitted to Stable, Night, None  

### [Frontend]
:heavy_plus_sign: menu items became more highlighted  
:heavy_plus_sign: selected item is saved in the storage now  
:heavy_plus_sign: added saving for current and last versions  
:heavy_minus_sign: increased text's field length and size of change editor.  

### [Utils]
:heavy_plus_sign: changeLogger.Console has started work with CI  
> new ChangeLogger builds will be created now for each new code, added to the master branch  

:hammer: fixed parser, now versions have a good look  

## Version 2018.4

### [Backend]
:heavy_plus_sign: added history of CRUD  
:heavy_plus_sign: added frontend part of CRUD history  
:heavy_plus_sign: added user id auto update  
:heavy_minus_sign: reduced size of returned json by server  

### [Common]
:heavy_plus_sign: improved changes count query, modified requester, settled 5001 port, added development/production se  
:heavy_plus_sign: added export of changes  
:heavy_plus_sign: added import of changes  
:heavy_plus_sign: added admin panel  
:heavy_plus_sign: added user roles  
:heavy_plus_sign: service has been replaced to new server https://changelogger.fast-report.com  

### [Frontend]
:heavy_plus_sign: added compact cards  

## Version 2018.3

### [Backend]
:heavy_plus_sign: added Auth server.  
> really added!  

:heavy_plus_sign: added method, that returns text file with specified changes—— removed page header from Auth page  
> "api/product/txt/{productId}/{filterType?}/{language?}/{versionId?}"  


### [Frontend]
:heavy_plus_sign: added paginator  
:heavy_plus_sign: added "Search results" section  
:heavy_plus_sign: first versions of the product creates with status Succeed now  

## Version 2018.2 [Commonplace]

### [Backend]
:heavy_plus_sign: initialized project  

### [Frontend]
:heavy_plus_sign: added hamburger menu  
:hammer: fixed bug with versions increment in VersionsEditor  

### [Model]
:heavy_plus_sign: added many to many relationship for ChangeGroups and Products  
