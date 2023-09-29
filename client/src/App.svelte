<script lang="ts">
  import { Router, Route } from 'svelte-routing'
  import Home from "./lib/Home.svelte";
  import Page1 from "./lib/Page1.svelte";
  import Page2 from "./lib/Page2.svelte";

</script>

<main>
    <Router>
        <Route path="/">
            <Home/>
        </Route>
        <Route path="/page1">
            <Page1/>
        </Route>
        <Route path="/page2">
            <Page2/>
        </Route>
    </Router>
</main>

<style>
</style>
