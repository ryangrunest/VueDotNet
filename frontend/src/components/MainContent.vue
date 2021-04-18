<template>
  <div class="section main-content">
    <div class="container">
      <form class="box">
        <div class="field">
          <label class="label">Favorite Food</label>
          <div class="control">
            <input
              v-model="foodName"
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
          {{ buttonText }}
        </button>
      </form>
    </div>
    <div class="container food-items-container py-5">
      <FoodItem
        v-bind:key="food.id"
        v-for="food in favoriteFoods"
        v-bind:isTasty="food.isTasty"
        v-bind:name="food.foodName"
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
import axios from "axios";

import FoodItem from "./FoodItem.vue";
import api from "../api";

export default {
  name: "MainContent",
  props: {},
  components: {
    FoodItem,
  },
  data() {
    return {
      isLoading: false,
      isTasty: false,
      foodName: "",
      favoriteFoods: [],
    };
  },
  methods: {
    addFood(event) {
      event.preventDefault();
      this.isLoading = true;
      const config = {
        method: "POST",
        url: "https://localhost:5001/api/FoodApi",
        data: {
          foodName: this.foodName,
          isTasty: this.isTasty,
        },
      };

      axios(config).then((response) => {
        console.log(response);
        this.isLoading = false;
        this.updateFavoriteFoods();
      });
    },
    async deleteFood(nameOfFood) {
      const allFoods = this.favoriteFoods;
      const food = allFoods.find((f) => nameOfFood == f.foodName);
      let success = await api.deleteFood(food);
      if (success) await this.updateFavoriteFoods();
      return true;
    },
    async updateFavoriteFoods() {
      this.favoriteFoods = await api.getAllFavoriteFoods();
    },
  },
  computed: {
    buttonText() {
      return this.isLoading === true ? "Loading..." : "Add Food to Favorites";
    },
  },
  mounted() {
    this.updateFavoriteFoods();
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
