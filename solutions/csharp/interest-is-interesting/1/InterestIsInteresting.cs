static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0) {
            return 3.213f;
        } 
        else if (balance >= 0 && balance < 1000) {
            return 0.5f;
        } 
        else if (balance >= 1000 && balance < 5000) {
            return 1.621f;
        }
        else {
            return 2.475f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        if (balance < 0) {
            return balance*0.03213m;
        } 
        else if (balance >= 0 && balance < 1000) {
            return balance*0.005m;
        } 
        else if (balance >= 1000 && balance < 5000) {
            return balance*0.01621m;
        }
        else {
            return balance*0.02475m;
        }
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        if (balance < 0) {
            return balance+balance*0.03213m;
        } 
        else if (balance >= 0 && balance < 1000) {
            return balance+balance*0.005m;
        } 
        else if (balance >= 1000 && balance < 5000) {
            return balance+balance*0.01621m;
        }
        else {
            return balance+balance*0.02475m;
        }
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int i = 0;
        if (balance == targetBalance || balance > targetBalance) {
            return i;
        }
        do {
            i++;
            if (balance < 0) {
                balance=balance+balance*0.03213m;
            } 
            else if (balance >= 0 && balance < 1000) {
                balance=balance+balance*0.005m;
            } 
            else if (balance >= 1000 && balance < 5000) {
                balance=balance+balance*0.01621m;
            }
            else {
                balance=balance+balance*0.02475m;
            }
        } while (balance < targetBalance);
        return i;
    }
}
