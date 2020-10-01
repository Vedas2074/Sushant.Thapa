using System;
class AccessModifier
{
    public int publicInteger=12;
    internal string internalString="qwe";
    protected decimal protectedDecimal=1234.234m;
    protected internal bool protectedinternalBool=true;
    private protected byte privateprotectedbyte=123;
    private char privateChar='E';

    static void Main3(string[] args)
    {
        AccessModifier Canwe = new AccessModifier();
        Canwe.internalString="Internal Access modifier only works in the same class";
        Canwe.privateChar='A';
        Canwe.privateprotectedbyte=89;
        Canwe.protectedDecimal=123.1234m;
        Canwe.protectedinternalBool=true;
        Canwe.publicInteger=1234;
      
    }


}
