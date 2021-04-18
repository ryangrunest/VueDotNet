<template>
  <div class="section main-content">
    <div class="container">
      <form class="box">
        <div class="field">
          <label class="label">Favorite Food</label>
          <div class="control">
            <input
              v-model="nameOfFood"
              class="input"
              type="text"
              placeholder="Spaghetti"
            />
          </div>
        </div>

        <div class="field">
          <label class="checkbox">
            <input v-model="isTasty" id="is-tasty-checkbox" type="checkbox" />
            Is Tasty
          </label>
        </div>

        <button @click="addFood" class="button is-primary">
          Add Food to Favorites
        </button>
      </form>
    </div>
    <div class="container food-items-container py-5">
      <FoodItem
        v-bind:key="index"
        v-for="(food, index) in favoriteFoods"
        v-bind:isTasty="food.isTasty"
        v-bind:name="food.nameOfFood"
        v-bind:deleteFunction="deleteFood"
        :class="
          food.isTasty
            ? 'has-background-primary has-text-light'
            : 'has-background-danger has-text-light'
        "
      ></FoodItem>
    </div>
  </div>
</template>

<script>
import FoodItem from "./FoodItem.vue";

export default {
  name: "MainContent",
  props: {},
  components: {
    FoodItem,
  },
  data() {
    return {
      isTasty: true,
      nameOfFood: "beans",
      favoriteFoods: [{ isTasty: true, nameOfFood: "beans" }],
    };
  },
  methods: {
    addFood(event) {
      event.preventDefault();
      console.log(event);
      console.log(`Food: ${this.nameOfFood}, isTasty: ${this.isTasty}`);

      this.favoriteFoods.push({
        isTasty: this.isTasty,
        nameOfFood: this.nameOfFood,
      });
    },
    deleteFood(nameOfFood) {
      for (const [index, food] of this.favoriteFoods.entries()) {
        if (food.nameOfFood === nameOfFood) {
          this.favoriteFoods.splice(index, 1);
          break;
        }
      }
    },
  },
};
</script>

<style scoped lang="scss">
.food-items-container {
  display: flex;
  flex-wrap: wrap;
  height: 30rem;
  margin-top: 2rem;
  overflow-y: scroll;
}
</style>
