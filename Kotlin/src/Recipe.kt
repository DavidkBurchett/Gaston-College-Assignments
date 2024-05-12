fun recipe(name: String, init: RecipeBuilder.() -> Unit) = RecipeBuilder(name).apply(init).build()
class RecipeBuilder(val recipeName: String) {
    var description: String = ""
    var instructions: String = ""
    private val ingredients: MutableList<Ingredient> = mutableListOf() 
    fun add(ingredient: Ingredient) = ingredients.add(ingredient)
    fun build() = when {
         isValid() -> Recipe(recipeName, description, ingredients)
         else -> throw IllegalStateException("Need at least 2 ingredients")
    }
    private fun isValid() = ingredients.size >= 2
    }
   data class Recipe(
      private val name: String, 
      private val description: String,
      private val ingredients: List<Ingredient>
   )
data class Ingredient(private val name: String, private val amount: Amount) 
data class Amount(private val amount: Number, private val measure: Measure)

// You can use other units that you're used to (cups, oz); note that this list is very incomplete
// 
// 
enum class Measure(val representation: String) { GRAMS("g"),
MILLILITERS("ml"), PIECES("pc"), PACK(" pack"), CUPS("c")
}
infix fun Amount.of(food: String) = Ingredient(food, this)
   val Number.g: Amount
   get() = Amount(this, Measure.GRAMS)
   val Number.ml: Amount
   get() = Amount(this, Measure.MILLILITERS)
   val Number.pc: Amount
   get() = Amount(this, Measure.PIECES)
   val Number.pack: Amount 
   get() = Amount(this, Measure.PACK)
   
   val bananaBreadRecipe = recipe("Banana & Walnut Bread") { description = "A healthy & tasty banana and walnut bread" 
   add(2.pc of "Ripe banana")
   add(125.ml of "Milk (any kind)")
   add(10.ml of "Lemon juice") 
   add(200.g of "All-purpose flour")
   
   add(100.g of "Whole wheat flour") 
   add(100.g of "Brown sugar") 
   add(1.pack of "Baking powder") 
   add(2.g of "Salt")
   add(20.g of "Flaxseeds") 
   add(100.g of "Walnuts")
   instructions = """Mash bananas and mix with rest of wet ingredients. Mix all dry ingredients and stir into wet ingredients until you get a (quite wet) dough. Put into baking form, sprinkle water on top,
and bake for 45min at 175Â°C. Cut a line into the top of the bread after around 5min of baking."""
}
   fun main()
{
    println(bananaBreadRecipe)
}