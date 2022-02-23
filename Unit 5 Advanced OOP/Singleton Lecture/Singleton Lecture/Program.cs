using Singleton_Lecture;

x();
y();



static void x()
{
    Singleton mySingleton = Singleton.getInstance();
}

static void y()
{
    Singleton mySingleton = Singleton.getInstance();
}