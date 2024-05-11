using LoggerUsingSingleton;
SingletonLoggerTest();

void SingletonLoggerTest()
{
	ILog logger = Log.GetInstance;
	
	try
	{
		string str = null;
        Console.WriteLine(str.ToString());
    }
	catch (Exception ex)
	{
		logger.LogException(ex.Message);	
	}
}