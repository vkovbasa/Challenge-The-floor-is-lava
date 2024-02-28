using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetShop : MonoBehaviour
{
   
   public Mammal mammal = new Cat();
}
public class Animal
{}
public class Mammal : Animal
{}
public class Cat : Mammal
{}
