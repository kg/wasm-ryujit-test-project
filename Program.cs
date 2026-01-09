using System.Runtime.CompilerServices;

public static unsafe class Program {
    [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
    static int addTwoInts (int a, int b) => a + b;

    [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
    static float addTwoFloats (float a, float b) => a + b;

    [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
    static int increment (int a) => a + 1;

    [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
    static float increaseFloat (float f) => f + 1.5f;

    [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
    static int derefIntPtr (int* p) => *p;

    [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
    static int derefBytePtr (byte* p) => *p;

    // FIXME: Cast
    /*
    [MethodImpl(MethodImplOptions.NoInlining)]
    static int demoteLong (long l) => unchecked((int)l);

    [MethodImpl(MethodImplOptions.NoInlining)]
    static long promoteInt (int i) => (long)i;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static float demoteDouble (double d) => unchecked((float)d);

    [MethodImpl(MethodImplOptions.NoInlining)]
    static double promoteFloat (float f) => (double)f;
    */

    [MethodImpl(MethodImplOptions.NoInlining)]
    static int select (int c, int t, int f) => c != 0 ? t : f;

    /*
    [MethodImpl(MethodImplOptions.NoInlining)]
    static void voidFunc () {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static void callVoidFunc () {
        voidFunc();
    }
    */

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    static bool nullCheck (object o) {
        return o != null;
    }

    [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
    public static int Main () => 0;
}