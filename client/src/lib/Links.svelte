<script lang="ts">
    import { Link } from 'svelte-routing'
</script>
<div>
    <Link to="/">Go Home</Link>
    <Link to="/page1">Go to Page 1</Link>
    <Link to="/page2">Go to Page 2</Link>
</div>
<style lang="css">
    div {
        display: flex;
        flex-direction: column;
    }
</style>