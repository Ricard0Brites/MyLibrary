    private bool Approx(float valA, float reference, float range)
    {
        if(valA + range >= -(reference + range) && valA + range <= reference + range)
        {
            return true;
        }
        return false;
        
    }
