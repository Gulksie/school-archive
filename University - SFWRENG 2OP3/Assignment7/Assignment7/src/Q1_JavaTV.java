/* Assignment 7 (100 marks in total; 5% of the final score of this course)
 *
 * Question 1 (40 marks)
    Use java to implement a TV that has many normal functions such as turn on and off, set channels and set volumes, etc.
    Requirements:
    * 1. The channel of a TV is no smaller than 1, and no greater than 120.
    * 2. The volume of a TV is no smaller than 1 and no greater than 7.
    * 3. One should not be able to change channel or volume when the TV is off.
 */

public class Q1_JavaTV {
    int channel = 1; // Default channel is 1
    int volumeLevel = 1; // Default volume level is 1
    boolean on = false; // If on = true, then TV is on. Otherwise, TV is off. By default, TV is off when you get a new TV.

    public Q1_JavaTV() {
        System.out.println("Congrats! You get a new TV!");
    }

    // (5 marks)
    public void turnOn() {
        System.out.println("Turn on tv.");
        this.on = true;
    }

    // (5 marks)
    public void turnOff() {
        System.out.println("Turn off tv.");
        this.on = false;
    }

    // (5 marks)
    public void setChannel(int newChannel) {
        if (this.on) {
            if (newChannel < 1 || newChannel > 120) {
                System.out.println("Invalid channel.");
                return;
            }

            this.channel = newChannel;

            System.out.println("Set Channel to: " + newChannel + ".");
        } else {
            System.out.println("The TV is off.");
        }
    }

    // (5 marks)
    public void setVolume(int newVolumeLevel) {
        if (this.on) {
            if (newVolumeLevel < 1 || newVolumeLevel > 7) {
                System.out.println("Invalid Volume");
                return;
            }

            this.volumeLevel = newVolumeLevel;

            System.out.println("Set Volume to: " + newVolumeLevel + ".");
        } else {
            System.out.println("The TV is off.");
        }
    }

    // (5 marks)
    public void channelUp() {
        if (this.on) {
            int newChannel = this.channel + 1;
            if (newChannel < 1 || newChannel > 120) {
                System.out.println("Channel can't go higher.");
                return;
            }

            this.channel++;

            System.out.println("Channel Up.");
        } else {
            System.out.println("The TV is off.");
        }
    }

    // (5 marks)
    public void channelDown() {
        if (this.on) {
            int newChannel = this.channel - 1;
            if (newChannel < 1 || newChannel > 120) {
                System.out.println("Channel can't go lower.");
                return;
            }

            this.channel--;

            System.out.println("Channel Down.");
        } else {
            System.out.println("The TV is off.");
        }
    }

    // (5 marks)
    public void volumeUp() {
        if (this.on) {
            int newVolume = this.volumeLevel + 1;
            if (newVolume < 1 || newVolume > 7) {
                System.out.println("Volume can't go higher.");
                return;
            }

            this.volumeLevel++;

            System.out.println("Volume Up.");
        } else {
            System.out.println("The TV is off.");
        }
    }

    // (5 marks)
    public void volumeDown() {
        if (this.on) {
            int newVolume = this.volumeLevel - 1;
            if (newVolume < 1 || newVolume > 7) {
                System.out.println("Volume can't go lower.");
                return;
            }

            this.volumeLevel--;

            System.out.println("Volume Down.");
        } else {
            System.out.println("The TV is off.");
        }
    }

    public String getTVStatus() {
        String status= "";

        if (on==true) {
            status += "Power is On  \t|\t";
            status += "Channel is: " + channel + "\t|\t";
            status += "Volume is: " + volumeLevel + "\t";
        } else{
            status += "Power is Off";
            return status;
        }

        return status;
    }

    public static void main(String arg[]) {
        /* TA may test different functions of the TV here */
        /* The following is just an example of how to test the TV's functions. */
        Q1_JavaTV my_tv = new Q1_JavaTV();
        System.out.println(my_tv.getTVStatus());
        my_tv.turnOn();
        System.out.println(my_tv.getTVStatus());
        my_tv.channelUp();
        System.out.println(my_tv.getTVStatus());
        my_tv.volumeUp();
        System.out.println(my_tv.getTVStatus());
    }
}
