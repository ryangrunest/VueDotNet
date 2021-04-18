<template>
  <div id="favorite-foods">
    <NavBar msg="Your Favorite Foods" />
    <MainContent />
    <Footer />
  </div>
</template>

<script>
import NavBar from "./components/NavBar.vue";
import MainContent from "./components/MainContent.vue";
import Footer from "./components/Footer.vue";

export default {
  name: "App",
  components: {
    NavBar,
    MainContent,
    Footer,
  },
};
</script>

<style scoped lang="scss">
#favorite-foods {
  padding-bottom: 10rem;
  min-height: 100vh;
}
</style>
