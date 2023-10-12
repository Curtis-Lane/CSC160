string firstNumber = "10";
string secondNumber = "2";

Jeff jeffOry = new Jeff(1, 2);

Console.WriteLine(jeffOry.addStuff());

public class Jeff {
    private short shortOne { get; set; }
    private short shortTwo { get; set; }

    public Jeff(short shortOne, short shortTwo) {
        this.shortOne = shortOne;
        this.shortTwo = shortTwo;
    }

    public bool doesJeffHaveBothShorts() {
        if(shortOne != 0 && shortTwo != 0) {
            return true;
        } else {
            return false;
        }
    }

    public int addStuff() {
        return shortOne + shortTwo;
    }

    public int addStuff(int firstNumber, int secondNumber) {
        return firstNumber + secondNumber;
    }

    /*    public int addStuff(string firstNumber, string secondNumber) {
            return addStuff(int.Parse(firstNumber), int.Parse(secondNumber));
        }*/

    public string addStuff(string firstNumber, string secondNumber) {
        return addStuff(int.Parse(firstNumber), int.Parse(secondNumber)).ToString();
    }
}