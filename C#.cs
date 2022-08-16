// valA ---------> is the value we are given to compare
// baseLine---> this is the value we want to  achieve
// range --------> how far off the ValA can be compared to baseLine

private bool CompareValueWithTolerance(float valA, float valB, float range)
    {
        if(valA + range >= -(valB + range) && valA + range <= valB + range)
        {
            return true;
        }
        return false;
    }

