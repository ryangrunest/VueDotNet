<template>
  <div class="food-item card">
    <div class="card-content">
      <div class="content">
        <p class="is-size-4">{{ name }}</p>
        <p>{{ isTasty ? "It's Tasty!" : "Not so tasty" }}</p>
        <button @click="deleteFunction(name)" class="delete">Delete</button>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "FoodItem",
  props: {
    isTasty: Boolean,
    name: String,
    deleteFunction: Function,
  },
};
</script>

<style scoped lang="scss">
.food-item {
  width: 30%;
  position: relative;
  margin: 1.5%;
  height: 150px;
}
.delete {
  position: absolute;
  top: 1rem;
  right: 1rem;
}
</style>
