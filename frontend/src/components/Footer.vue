<template>
  <footer class="footer">
    <div class="content has-text-centered">
      <p>
        Created by <a href="https://www.ryangrunest.com/">Ryan Grunest</a> with
        heavy lifting by
        <a target="_blank" href="https://bulma.io/"><strong>Bulma</strong></a
        >.
      </p>
    </div>
  </footer>
</template>

<script>
export default {
  name: "Footer",
  props: {},
};
</script>

<style scoped lang="scss">
.footer {
  position: absolute;
  bottom: 0;
  left: 0;
  width: 100vw;
  max-height: 10rem;
}
</style>
