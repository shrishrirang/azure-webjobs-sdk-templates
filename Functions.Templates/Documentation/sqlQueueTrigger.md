#### Settings for storage queue trigger

- `name` : The variable name used in function code for the queue message. 
- `connection` : The name of an app setting that contains a SQL connection string. If you leave `connection` empty, the trigger will work with the default storage connection string for the function app, which is specified by the AzureWebJobsSqlQueue app setting.
- `databaseName` : SQL Database name that defines the queue. This need not be defined if the connection string already defines the database to use. If not, this must be defined. If both are defined, this property overrides the database specified in the connection string.
- `queueName` : The name of the queue to poll
- `queueName` : The name of the SQL contract to use for reading the message
- `messageType` : SQL data type of the message
- `direction` : Must be set to *in*. 

#### Additional metadata for Storage Queue trigger

No additional metadata is defined currently. 

#### C# types for Storage Queue trigger

The queue message can only be serialized to `string` currently. Support for more types will be added going forward.
