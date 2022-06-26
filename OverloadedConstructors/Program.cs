﻿static void Main(String[] args)
{
    // overloaded constructors = technique to create multiple constructors,
    //                           with a differnt set of parameters.
    //                           name + parameters = signature

    Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella", "pepperoni");

    Console.ReadKey();
}

class Pizza
{
    String bread;
    String sauce;
    String cheese;
    String topping;

    public Pizza(String bread)
    {
        this.bread = bread;
    }

    public Pizza(String bread, String sauce)
    {
        this.bread = bread;
        this.sauce = sauce;
    }

    public Pizza(String bread, String sauce, String cheese)
    {
        this.bread = bread;
        this.sauce = sauce;
        this.cheese = cheese;
    }
    public Pizza(String bread, String sauce, String cheese, String topping)
    {
        this.bread = bread;
        this.sauce = sauce;
        this.cheese = cheese;
        this.topping = topping;
    }

}