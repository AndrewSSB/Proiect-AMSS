export default function Boook(props) {
    const {id, imagePath, title, description, author} = props

    return (
        <div
            key={id}
            className={"product"}
        >
            <img
                src={imagePath}
                alt={`Image of ${title}`}
                className={"image-product"}
            />
            <h3>{`${title} by ${author}`}</h3>
            <p>{description}</p>
        </div>
    );
}