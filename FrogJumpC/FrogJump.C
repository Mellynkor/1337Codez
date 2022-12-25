int solution(int X, int Y, int D) {
    for(int i = 1; X<Y; i++)
    {
        X+=D;
        if(X>=Y)
        {
            return i;
        }
    }
    return 0;
}