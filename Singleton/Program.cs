// Singleton design - Only one object should be used. Ex : Logger, etc
SingletonEager instance = SingletonEager.GetInstance();
instance.PrintMethod();

// Lazy design - initialize if object is not available.
SingletonLazy  instance2 = SingletonLazy.GetInstance();
instance2.PrintMethod();