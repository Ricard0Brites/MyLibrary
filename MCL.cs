// valA ---------> is the value we are given to compare
// baseLine---> this is the value we want to  achieve
// range --------> how far off the ValA can be compared to baseLine

private bool Approx(float valA, float baseLine, float range)
    {
        if(valA + range >= -(baseLine + range) && valA + range <= baseLine + range)
        {
            return true;
        }
        return false;
    }
