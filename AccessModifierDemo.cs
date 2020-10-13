class AccessModifierDemo
{
    internal void InternalAccess()
    {

    }
    public void PublicAccess()
    {
        InternalAccess();
    }
}
class ModifierDemo
{
    void InternalAccess()
    {
       Person person = new Person();
       person.Age=34;

    }


}