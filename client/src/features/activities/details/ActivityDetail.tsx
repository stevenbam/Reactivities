import {
    Button,
  Card,
  CardActions,
  CardContent,
  CardMedia,
  Typography,
} from "@mui/material";

type Props = {
  activity: Activity;
};

export default function ActivityDetail({ activity }: Props) {
  return (
    <Card sx={{ borderRadius: 3, padding: 2 }}>
      <CardMedia
        component={"img"}
        src={`/images/categoryImages/${activity.category}.jpg`}
      />
      <CardContent>
        <Typography variant="h5">{activity.title}</Typography>
        <Typography variant="subtitle1" fontWeight="light">
          {activity.date}
        </Typography>
        <Typography variant="body1">{activity.description}</Typography>
        <CardActions>
          <Button color="primary">Edit</Button>
          <Button color="inherit">Cancel</Button>
        </CardActions>
      </CardContent>
    </Card>
  );
}
